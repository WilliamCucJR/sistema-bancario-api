using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly TipoDocumentoTable _context;

        public TipoDocumentoController(TipoDocumentoTable context)
        {
            _context = context;
        }

        // GET: api/TipoDocumento
        [HttpGet("GetAllTipoDocumentos")]
        public async Task<ActionResult<IEnumerable<TIPO_DOCUMENTO>>> GetTipoDocumentos()
        {
            return await _context.TipoDocs.FromSqlRaw("SELECT * FROM TIPO_DOCUMENTO WHERE OPERACION = 1 ORDER BY ID DESC").ToListAsync();
        }

        [HttpGet("GetAllTipoDocumentosDebito")]
        public async Task<ActionResult<IEnumerable<TIPO_DOCUMENTO>>> GetTipoDocumentosDebito()
        {
            return await _context.TipoDocs.FromSqlRaw("SELECT * FROM TIPO_DOCUMENTO WHERE OPERACION = -1 ORDER BY ID DESC").ToListAsync();
        }

        [HttpGet("GetAllTipoDocumentosCredito")]
        public async Task<ActionResult<IEnumerable<TIPO_DOCUMENTO>>> GetTipoDocumentosCredito()
        {
            return await _context.TipoDocs.FromSqlRaw("SELECT * FROM TIPO_DOCUMENTO ORDER BY ID DESC").ToListAsync();
        }

        // GET: api/TipoDocumento/5
        [HttpGet("GetTipoDocumento/{id}")]
        public async Task<ActionResult<TIPO_DOCUMENTO>> GetTipoDocumento(int id)
        {
            var tipoDocumento = await _context.TipoDocs.FromSqlRaw($"SELECT * FROM TIPO_DOCUMENTO WHERE ID = {id}").FirstOrDefaultAsync();

            if (tipoDocumento == null)
            {
                return NotFound();
            }

            return tipoDocumento;
        }

        // POST: api/TipoDocumento
        [HttpPost("CreateTipoDocumento")]
        public async Task<ActionResult<TIPO_DOCUMENTO>> PostTipoDocumento(TIPO_DOCUMENTO tipoDocumento)
        {
            string consulta = "INSERT INTO TIPO_DOCUMENTO (NOMBRE_DOCUMENTO, DESCRIPCION, OPERACION) VALUES (:nombreDocumento, :descripcion, :operacion)";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("nombreDocumento", tipoDocumento.NOMBRE_DOCUMENTO),
                new OracleParameter("descripcion", tipoDocumento.DESCRIPCION),
                new OracleParameter("operacion", tipoDocumento.OPERACION)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return CreatedAtAction("GetTipoDocumento", new { id = tipoDocumento.ID }, new { message = "Tipo de documento creado con éxito", tipoDocumento });
        }

        // PUT: api/TipoDocumento/5
        [HttpPut("UpdateTipoDocumento/{id}")]
        public async Task<IActionResult> PutTipoDocumento(int id, TIPO_DOCUMENTO tipoDocumento)
        {
            if (id != tipoDocumento.ID)
            {
                return BadRequest();
            }

            string consulta = "UPDATE TIPO_DOCUMENTO SET NOMBRE_DOCUMENTO = :nombreDocumento, DESCRIPCION = :descripcion, OPERACION = :operacion WHERE ID = :id";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("nombreDocumento", tipoDocumento.NOMBRE_DOCUMENTO),
                new OracleParameter("descripcion", tipoDocumento.DESCRIPCION),
                new OracleParameter("operacion", tipoDocumento.OPERACION),
                new OracleParameter("id", id)
            };
            await _context.Database.ExecuteSqlRawAsync(consulta, parametros);

            return Ok(new { message = "Tipo de documento actualizado con éxito" });
        }

        // DELETE: api/TipoDocumento/5
        [HttpDelete("DeleteTipoDocumento/{id}")]
        public async Task<IActionResult> DeleteTipoDocumento(int id)
        {
            await _context.Database.ExecuteSqlRawAsync($"DELETE FROM TIPO_DOCUMENTO WHERE ID = {id}");

            return Ok(new { message = "Tipo de documento eliminado con éxito" });
        }
    }
}
