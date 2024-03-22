using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [ApiController]
    [Route("bancoAPI/[controller]")]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly TipoDocumentoTable _tipoDocTable;

        public TipoDocumentoController(TipoDocumentoTable tipoDocTable)
        {
            _tipoDocTable = tipoDocTable;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var userLoginGet = await _tipoDocTable.TipoDocs.ToListAsync();
            return Ok(userLoginGet);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(TIPO_DOCUMENTO log)
        {
            var userLoginPost = await _tipoDocTable.TipoDocs.AddAsync(log);
            await _tipoDocTable.SaveChangesAsync();
            return Ok("El registro se inserto correctamente!");
        }



        [HttpPut]
        public async Task<IActionResult> PutAsync(TIPO_DOCUMENTO log)
        {
            _tipoDocTable.TipoDocs.Update(log);
            await _tipoDocTable.SaveChangesAsync();
            return NoContent();
        }

        [Route("{USERID}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int USERID)
        {
            var userLoginDelete = await _tipoDocTable.TipoDocs.FindAsync(USERID);
            if (userLoginDelete == null)
            {
                return NotFound();
            }

            _tipoDocTable.TipoDocs.Remove(userLoginDelete);
            await _tipoDocTable.SaveChangesAsync();
            return Ok("El registro se elimino de manera correcta");
        }

        [Route("getuserbyid/{userid}")]
        [HttpGet]
        public async Task<IActionResult> getByUSERID(int userid)
        {
            var usergetByUSERID = await _tipoDocTable.TipoDocs.FindAsync(userid);
            return Ok(usergetByUSERID);
        }
    }
}
