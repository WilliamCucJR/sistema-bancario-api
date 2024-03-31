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
    public class BancoController : ControllerBase
    {
        private readonly BancoTable _context;

        public BancoController(BancoTable context)
        {
            _context = context;
        }

        // GET: api/Banco
        [HttpGet("GetAllBancos")]
        public async Task<ActionResult<IEnumerable<BANCO>>> GetBancos()
        {
            return await _context.Bancos.FromSqlRaw("SELECT * FROM BANCO ORDER BY ID_BANCO DESC").ToListAsync();
        }

        // GET: api/Banco/5
        [HttpGet("GetBanco/{id}")]
        public async Task<ActionResult<BANCO>> GetBanco(int id)
        {
            var banco = await _context.Bancos.FromSqlRaw($"SELECT * FROM BANCO WHERE ID_BANCO = {id}").FirstOrDefaultAsync();

            if (banco == null)
            {
                return NotFound();
            }

            return banco;
        }

        // POST: api/Banco
        [HttpPost("CreateBanco")]
        public async Task<ActionResult<BANCO>> PostBanco(BANCO banco)
        {
            DateTime fechaDeCreacion;
            bool isValid = DateTime.TryParseExact(banco.FECHA_DE_CREACION, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaDeCreacion);

            if (!isValid)
            {
                return BadRequest("Formato de fecha inválido. Debe ser 'yyyy/MM/dd'.");
            }

            string consulta = "INSERT INTO BANCO (NOMBRE_BANCO, FECHA_DE_CREACION, ID_USUARIO) VALUES (:nombreBanco, TO_DATE(:fechaDeCreacion, 'YYYY-MM-DD'), :idUsuario)";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("nombreBanco", banco.NOMBRE_BANCO),
                new OracleParameter("fechaDeCreacion", fechaDeCreacion.ToString("yyyy-MM-dd")),
                new OracleParameter("idUsuario", banco.ID_USUARIO)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return CreatedAtAction("GetBanco", new { id = banco.ID_BANCO }, new { message = "Banco creado con éxito", banco });
        }

        // PUT: api/Banco/5
        [HttpPut("UpdateBanco/{id}")]
        public async Task<IActionResult> PutBanco(int id, BANCO banco)
        {
            if (id != banco.ID_BANCO)
            {
                return BadRequest();
            }

            string consulta = "UPDATE BANCO SET NOMBRE_BANCO = :nombreBanco WHERE ID_BANCO = :id";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("nombreBanco", banco.NOMBRE_BANCO),
                new OracleParameter("id", id)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return Ok(new { message = "Banco actualizado con éxito" });
        }

        // DELETE: api/Banco/5
        [HttpDelete("DeleteBanco/{id}")]
        public async Task<IActionResult> DeleteBanco(int id)
        {
            await _context.Database.ExecuteSqlRawAsync($"DELETE FROM BANCO WHERE ID_BANCO = {id}");

            return Ok(new { message = "Banco eliminado con éxito" });
        }
    }
}
