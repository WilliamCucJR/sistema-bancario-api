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
    public class TipoCuentaController : ControllerBase
    {
        private readonly TipoCuentaTable _context;

        public TipoCuentaController(TipoCuentaTable context)
        {
            _context = context;
        }

        // GET: api/TipoCuenta
        [HttpGet("GetAllTipoCuentas")]
        public async Task<ActionResult<IEnumerable<TIPO_CUENTA>>> GetTipoCuentas()
        {
            return await _context.TipoCuentas.FromSqlRaw("SELECT * FROM TIPO_CUENTA ORDER BY ID DESC").ToListAsync();
        }

        // GET: api/TipoCuenta/5
        [HttpGet("GetTipoCuenta/{id}")]
        public async Task<ActionResult<TIPO_CUENTA>> GetTipoCuenta(int id)
        {
            var tipoCuenta = await _context.TipoCuentas.FromSqlRaw($"SELECT * FROM TIPO_CUENTA WHERE ID = {id}").FirstOrDefaultAsync();

            if (tipoCuenta == null)
            {
                return NotFound();
            }

            return tipoCuenta;
        }

        // POST: api/TipoCuenta
        [HttpPost("CreateTipoCuenta")]
        public async Task<ActionResult<TIPO_CUENTA>> PostTipoCuenta(TIPO_CUENTA tipoCuenta)
        {
            DateTime fechaDeCreacion;
            bool isValid = DateTime.TryParseExact(tipoCuenta.FECHA_DE_CREACION, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaDeCreacion);

            if (!isValid)
            {
                return BadRequest("Formato de fecha inválido. Debe ser 'yyyy/MM/dd'.");
            }

            string consulta = "INSERT INTO TIPO_CUENTA (TIPO_DE_CUENTA, FECHA_DE_CREACION) VALUES (:tipoDeCuenta, TO_DATE(:fechaDeCreacion, 'YYYY-MM-DD'))";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("tipoDeCuenta", tipoCuenta.TIPO_DE_CUENTA),
                new OracleParameter("fechaDeCreacion", fechaDeCreacion.ToString("yyyy-MM-dd"))
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return CreatedAtAction("GetTipoCuenta", new { id = tipoCuenta.ID }, new { message = "Tipo de cuenta creado con éxito", tipoCuenta });
        }

        // PUT: api/TipoCuenta/5
        [HttpPut("UpdateTipoCuenta/{id}")]
        public async Task<IActionResult> PutTipoCuenta(int id, TIPO_CUENTA tipoCuenta)
        {
            if (id != tipoCuenta.ID)
            {
                return BadRequest();
            }

            string consulta = "UPDATE TIPO_CUENTA SET TIPO_DE_CUENTA = :tipoDeCuenta WHERE ID = :id";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("tipoDeCuenta", tipoCuenta.TIPO_DE_CUENTA),
                new OracleParameter("id", id)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return Ok(new { message = "Tipo de cuenta actualizado con éxito" });
        }

        // DELETE: api/TipoCuenta/5
        [HttpDelete("DeleteTipoCuenta/{id}")]
        public async Task<IActionResult> DeleteTipoCuenta(int id)
        {
            await _context.Database.ExecuteSqlRawAsync($"DELETE FROM TIPO_CUENTA WHERE ID = {id}");

            return Ok(new { message = "Tipo de cuenta eliminado con éxito" });
        }
    }
}
