using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedaController : ControllerBase
    {
        private readonly MonedaTable _context;

        public MonedaController(MonedaTable context)
        {
            _context = context;
        }

        // GET: api/Moneda
        [HttpGet("GetAllMonedas")]
        public async Task<ActionResult<IEnumerable<MONEDA>>> GetMonedas()
        {
            return await _context.Monedas.FromSqlRaw("SELECT * FROM MONEDA ORDER BY ID DESC").ToListAsync();
        }

        // GET: api/Moneda/5
        [HttpGet("GetMoneda/{id}")]
        public async Task<ActionResult<MONEDA>> GetMoneda(int id)
        {
            var moneda = await _context.Monedas.FromSqlRaw($"SELECT * FROM MONEDA WHERE ID = {id}").FirstOrDefaultAsync();

            if (moneda == null)
            {
                return NotFound();
            }

            return moneda;
        }

        // POST: api/Moneda
        [HttpPost("CreateMoneda")]
        public async Task<ActionResult<MONEDA>> PostMoneda(MONEDA moneda)
        {
            string consulta = "INSERT INTO MONEDA (TIPO_MONEDA, TASA_DE_CAMBIO) VALUES (:tipoMoneda, :tasaDeCambio)";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("tipoMoneda", moneda.TIPO_MONEDA),
                new OracleParameter("tasaDeCambio", moneda.TASA_DE_CAMBIO)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return CreatedAtAction("GetMoneda", new { id = moneda.ID }, new { message = "Moneda creada con éxito", moneda });
        }

        // PUT: api/Moneda/5
        [HttpPut("UpdateMoneda/{id}")]
        public async Task<IActionResult> PutMoneda(int id, MONEDA moneda)
        {
            if (id != moneda.ID)
            {
                return BadRequest();
            }

            string consulta = "UPDATE MONEDA SET TIPO_MONEDA = :tipoMoneda, TASA_DE_CAMBIO = :tasaDeCambio WHERE ID = :id";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("tipoMoneda", moneda.TIPO_MONEDA),
                new OracleParameter("tasaDeCambio", moneda.TASA_DE_CAMBIO),
                new OracleParameter("id", id)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return Ok(new { message = "Moneda actualizada con éxito" });
        }

        // DELETE: api/Moneda/5
        [HttpDelete("DeleteMoneda/{id}")]
        public async Task<IActionResult> DeleteMoneda(int id)
        {
            await _context.Database.ExecuteSqlRawAsync($"DELETE FROM MONEDA WHERE ID = {id}");

            return Ok(new { message = "Moneda eliminada con éxito" });
        }
    }
}