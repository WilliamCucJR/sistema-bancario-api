using System.Data;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {
        private readonly MovimientosTable _context;

        public MovimientosController(MovimientosTable context)
        {
            _context = context;
        }

        // GET: api/Movimientos
        [HttpGet("GetAllMovimientos")]
        public async Task<ActionResult<IEnumerable<MOVIMIENTOS>>> GetMovimientos()
        {
            return await _context.Moves.FromSqlRaw("SELECT * FROM MOVIMIENTOS ORDER BY ID_CUENTA DESC").ToListAsync();
        }


        // GET: api/Movimientos/5
        [HttpGet("GetMovimiento/{id}")]
        public async Task<ActionResult<MOVIMIENTOS>> GetMovimiento(int id)
        {
            var movimiento = await _context.Moves.FromSqlRaw($"SELECT * FROM MOVIMIENTOS WHERE ID_CUENTA = {id}").FirstOrDefaultAsync();

            if (movimiento == null)
            {
                return NotFound();
            }

            return movimiento;
        }

        [HttpGet("GetMovimiento/{idCuenta}/{idBanco}/{mes}/{anio}")]
        public async Task<ActionResult<IEnumerable<MOVIMIENTOS>>> GetMovimiento(int idCuenta, int idBanco, int mes, int anio)
        {
            var movimientos = await _context.Moves
                .FromSqlRaw($"  SELECT  a.ID_MOVIMIENTO, a.ID_CUENTA, a.ID_DOCUMENTO, a.DESCRIPCION, a.FECHA, " +
                $"                      a.NO_DOCUMENTO, a.TIPO_DOCUMENTO_ID, a.MONTO, a.DOCUMENTO_CONTABLE" +
                $"              FROM MOVIMIENTOS a" +
                $"              INNER JOIN CUENTA_BANCARIA b ON b.ID_CUENTA = a.ID_CUENTA" +
                $"              WHERE b.ID_CUENTA = {idCuenta} AND b.BANCO_ID = {idBanco}" +
                $"              AND (EXTRACT(YEAR FROM FECHA) = {anio} AND EXTRACT(MONTH FROM FECHA) = {mes})")
                .ToListAsync();

            if (movimientos == null)
            {
                return NotFound();
            }

            return movimientos;
        }

        // POST: api/Movimientos
        [HttpPost("CreateMovimiento")]
        public async Task<ActionResult<MOVIMIENTOS>> PostMovimiento(MOVIMIENTOS movimiento)
        {

            string consulta = "INSERT INTO MOVIMIENTOS (ID_CUENTA, ID_MOVIMIENTO, ID_DOCUMENTO, DESCRIPCION, FECHA, NO_DOCUMENTO, TIPO_DOCUMENTO_ID, MONTO, DOCUMENTO_CONTABLE) VALUES (:idCuenta, :idMovimiento, :idDocumento, :descripcion, TO_TIMESTAMP(:fecha, 'YYYY-MM-DD HH24:MI:SS'), :noDocumento, :tipoDocumentoId, :monto, :documentoContable)";
            
            var parametros = new OracleParameter[]
            {
                new OracleParameter("idCuenta", movimiento.ID_CUENTA),
                new OracleParameter("idMovimiento", movimiento.ID_MOVIMIENTO),
                new OracleParameter("idDocumento", movimiento.ID_DOCUMENTO),
                new OracleParameter("descripcion", movimiento.DESCRIPCION),
                new OracleParameter("fecha", movimiento.FECHA),
                new OracleParameter("noDocumento", movimiento.NO_DOCUMENTO),
                new OracleParameter("tipoDocumentoId", movimiento.TIPO_DOCUMENTO_ID),
                new OracleParameter("monto", movimiento.MONTO),
                new OracleParameter("documentoContable", movimiento.DOCUMENTO_CONTABLE),
                new OracleParameter("saldo", movimiento.MONTO)
            };
           
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return CreatedAtAction("GetMovimiento", new { id = movimiento.ID_CUENTA }, new { message = "Movimiento creado con éxito", movimiento });
        }

        // POST: api/Movimientos
        [HttpPost("CreateMovimientoStoreProcedure")]
        public async Task<ActionResult<MOVIMIENTOS>> PostMovimientoStoreProcedure(MOVIMIENTOS movimiento)
        {

            string consulta = @"
        DECLARE 
            msg VARCHAR2(200);
        BEGIN 
            updateSaldo(:idMovimiento, :idCuenta, :idDocumento, :descripcion, :fecha, :noDocumento, :tipoDocumentoId, :monto, :documentoContable, msg);
            :mensaje := msg;
        END;";

            var parametros = new OracleParameter[]
            {
        new OracleParameter("idMovimiento", OracleDbType.Int32) { Value = movimiento.ID_MOVIMIENTO },
        new OracleParameter("idCuenta", OracleDbType.Int32) { Value = movimiento.ID_CUENTA },
        new OracleParameter("idDocumento", OracleDbType.Int32) { Value = movimiento.ID_DOCUMENTO },
        new OracleParameter("descripcion", OracleDbType.Varchar2) { Value = movimiento.DESCRIPCION },
        new OracleParameter("fecha", OracleDbType.Varchar2) { Value = movimiento.FECHA },
        new OracleParameter("noDocumento", OracleDbType.Varchar2) { Value = movimiento.NO_DOCUMENTO },
        new OracleParameter("tipoDocumentoId", OracleDbType.Int32) { Value = movimiento.TIPO_DOCUMENTO_ID },
        new OracleParameter("monto", OracleDbType.Decimal) { Value = movimiento.MONTO },
        new OracleParameter("documentoContable", OracleDbType.Varchar2) { Value = movimiento.DOCUMENTO_CONTABLE },
        new OracleParameter("mensaje", OracleDbType.Varchar2, 200) { Direction = ParameterDirection.Output }
            };

            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            string mensaje = parametros[9].Value?.ToString() ?? "No se recibió ningún mensaje"; // Captura el valor del parámetro de salida y maneja el posible valor nulo

            return Ok(new { message = mensaje });
        }



        // PUT: api/Movimientos/5
        [HttpPut("UpdateMovimiento/{id}")]
        public async Task<IActionResult> PutMovimiento(int id, MOVIMIENTOS movimiento)
        {
            if (id != movimiento.ID_CUENTA)
            {
                return BadRequest();
            }

            DateTime fecha;
            bool isValid = DateTime.TryParseExact(movimiento.FECHA.ToString(), "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);

            if (!isValid)
            {
                return BadRequest("Formato de fecha inválido. Debe ser 'yyyy/MM/dd'.");
            }

            string consulta = "UPDATE MOVIMIENTOS SET ID_MOVIMIENTO = :idMovimiento, DESCRIPCION = :descripcion, FECHA = TO_DATE(:fecha, 'YYYY-MM-DD'), NO_DOCUMENTO = :noDocumento, TIPO_DOCUMENTO_ID = :tipoDocumentoId, MONTO = :monto, DOCUMENTO_CONTABLE = :documentoContable WHERE ID_CUENTA = :id";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("idMovimiento", movimiento.ID_MOVIMIENTO),
                new OracleParameter("descripcion", movimiento.DESCRIPCION),
                new OracleParameter("fecha", fecha.ToString("yyyy-MM-dd")),
                new OracleParameter("noDocumento", movimiento.NO_DOCUMENTO),
                new OracleParameter("tipoDocumentoId", movimiento.TIPO_DOCUMENTO_ID),
                new OracleParameter("monto", movimiento.MONTO),
                new OracleParameter("documentoContable", movimiento.DOCUMENTO_CONTABLE),
                new OracleParameter("id", id)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return Ok(new { message = "Movimiento actualizado con éxito" });
        }

        // DELETE: api/Movimientos/5
        [HttpDelete("DeleteMovimiento/{id}")]
        public async Task<IActionResult> DeleteMovimiento(int id)
        {
            await _context.Database.ExecuteSqlRawAsync($"DELETE FROM MOVIMIENTOS WHERE ID_CUENTA = {id}");

            return Ok(new { message = "Movimiento eliminado con éxito" });
        }

        // DELETE: api/Movimientos/5
        [HttpDelete("DeleteMovimientoDocumento/{no_documento}")]
        public async Task<IActionResult> DeleteMovimientoDocumento(string no_documento)
        {
            await _context.Database.ExecuteSqlRawAsync($"DELETE FROM MOVIMIENTOS WHERE NO_DOCUMENTO = {no_documento}");

            return Ok(new { message = "Movimiento eliminado con éxito" });
        }

        // DELETE: api/Movimientos/5
        [HttpDelete("DeleteMovimientoDocumentoProcedure/{no_documento}")]
        public async Task<IActionResult> DeleteMovimientoDocumentoProcedure(string no_documento)
        {
            try
            {
                var parameter = new OracleParameter("p_no_documento", OracleDbType.Varchar2);
                parameter.Value = no_documento;

                // Llamar al procedimiento almacenado
                await _context.Database.ExecuteSqlRawAsync("BEGIN eliminarMovimiento(:p_no_documento); END;", parameter);

                // Devolver el mensaje de éxito como respuesta
                return Ok(new { message = "Movimiento eliminado con éxito" });
            }
            catch (Exception ex)
            {
                // Manejar errores y devolver el mensaje de error como respuesta
                return BadRequest(new { message = "Error al eliminar el movimiento: " + ex.Message });
            }
        }


        // GET: api/Movimientos/GetNotasDebitoPorBanco/{idBanco}
        [HttpGet("GetNotasDebitoPorBanco/{idBanco}")]
        public async Task<ActionResult<IEnumerable<MOVIMIENTOS>>> GetNotasDebitoPorBanco(int idBanco)
        {
            var notasDebito = await _context.Moves
                .FromSqlRaw(@"
            SELECT a.ID_MOVIMIENTO, a.ID_CUENTA, a.ID_DOCUMENTO, a.DESCRIPCION, a.FECHA,
                   a.NO_DOCUMENTO, a.TIPO_DOCUMENTO_ID, 1 * a.MONTO AS MONTO, a.DOCUMENTO_CONTABLE
            FROM MOVIMIENTOS a
            INNER JOIN CUENTA_BANCARIA b ON b.ID_CUENTA = a.ID_CUENTA
            INNER JOIN BANCO c ON c.ID_BANCO = b.BANCO_ID
            INNER JOIN TIPO_DOCUMENTO d ON d.ID = a.ID_DOCUMENTO
            WHERE d.OPERACION < 0 AND c.ID_BANCO = {0} ORDER BY a.ID_MOVIMIENTO DESC", idBanco)
                .ToListAsync();

            return notasDebito;
        }

        // GET: api/Movimientos/GetNotasCreditoPorBanco/{idBanco}
        [HttpGet("GetNotasCreditoPorBanco/{idBanco}")]
        public async Task<ActionResult<IEnumerable<MOVIMIENTOS>>> GetNotasCreditoPorBanco(int idBanco)
        {
            var notasCredito = await _context.Moves
                .FromSqlRaw(@"
            SELECT a.ID_MOVIMIENTO, a.ID_CUENTA, a.ID_DOCUMENTO, a.DESCRIPCION, a.FECHA,
                    a.NO_DOCUMENTO, a.TIPO_DOCUMENTO_ID, 1 * a.MONTO AS MONTO, a.DOCUMENTO_CONTABLE
            FROM MOVIMIENTOS a
            INNER JOIN CUENTA_BANCARIA b ON b.ID_CUENTA = a.ID_CUENTA
            INNER JOIN BANCO c ON c.ID_BANCO = b.BANCO_ID
            INNER JOIN TIPO_DOCUMENTO d ON d.ID = a.ID_DOCUMENTO
            WHERE d.OPERACION > 0 AND c.ID_BANCO = {0} ORDER BY a.ID_MOVIMIENTO DESC", idBanco)
                .ToListAsync();

            return notasCredito;
        }
    }
}
