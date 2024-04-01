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

        // POST: api/Movimientos
        // POST: api/Movimientos
        [HttpPost("CreateMovimiento")]
        public async Task<ActionResult<MOVIMIENTOS>> PostMovimiento(MOVIMIENTOS movimiento)
        {
            if (movimiento.FECHA == null)
            {
                return BadRequest("El campo FECHA es requerido.");
            }

            DateTime fecha;
            bool isValid = DateTime.TryParseExact(movimiento.FECHA.Value.ToString("yyyy/MM/dd HH:mm:ss"), "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);

            if (!isValid)
            {
                return BadRequest("Formato de fecha inválido. Debe ser 'yyyy/MM/dd HH:mm:ss'.");
            }

            string consulta = "INSERT INTO MOVIMIENTOS (ID_CUENTA, ID_MOVIMIENTO, DESCRIPCION, FECHA, NO_DOCUMENTO, TIPO_DOCUMENTO_ID, MONTO, DOCUMENTO_CONTABLE) VALUES (:idCuenta, :idMovimiento, :descripcion, TO_TIMESTAMP(:fecha, 'YYYY-MM-DD HH24:MI:SS'), :noDocumento, :tipoDocumentoId, :monto, :documentoContable)";
            var parametros = new OracleParameter[]
            {
        new OracleParameter("idCuenta", movimiento.ID_CUENTA),
        new OracleParameter("idMovimiento", movimiento.ID_MOVIMIENTO),
        new OracleParameter("descripcion", movimiento.DESCRIPCION),
        new OracleParameter("fecha", fecha.ToString("yyyy-MM-dd HH:mm:ss")),
        new OracleParameter("noDocumento", movimiento.NO_DOCUMENTO),
        new OracleParameter("tipoDocumentoId", movimiento.TIPO_DOCUMENTO_ID),
        new OracleParameter("monto", movimiento.MONTO),
        new OracleParameter("documentoContable", movimiento.DOCUMENTO_CONTABLE)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return CreatedAtAction("GetMovimiento", new { id = movimiento.ID_CUENTA }, new { message = "Movimiento creado con éxito", movimiento });
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
    }
}
