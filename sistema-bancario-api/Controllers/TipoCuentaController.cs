using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [ApiController]
    [Route("bancoAPI/[controller]")]
    public class TipoCuentaController : ControllerBase
    {
        private readonly TipoCuentaTable _tipoCuentaTable;

        public TipoCuentaController(TipoCuentaTable tipoCuenta)
        {
            _tipoCuentaTable = tipoCuenta;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var userLoginGet = await _tipoCuentaTable.TipoCuentas.ToListAsync();
            return Ok(userLoginGet);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(TIPO_CUENTA log)
        {
            var userLoginPost = await _tipoCuentaTable.TipoCuentas.AddAsync(log);
            await _tipoCuentaTable.SaveChangesAsync();
            return Ok("El registro se inserto correctamente!");
        }



        [HttpPut]
        public async Task<IActionResult> PutAsync(TIPO_CUENTA log)
        {
            _tipoCuentaTable.TipoCuentas.Update(log);
            await _tipoCuentaTable.SaveChangesAsync();
            return NoContent();
        }

        [Route("{USERID}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int USERID)
        {
            var userLoginDelete = await _tipoCuentaTable.TipoCuentas.FindAsync(USERID);
            if (userLoginDelete == null)
            {
                return NotFound();
            }

            _tipoCuentaTable.TipoCuentas.Remove(userLoginDelete);
            await _tipoCuentaTable.SaveChangesAsync();
            return Ok("El registro se elimino de manera correcta");
        }

        [Route("getuserbyid/{userid}")]
        [HttpGet]
        public async Task<IActionResult> getByUSERID(int userid)
        {
            var usergetByUSERID = await _tipoCuentaTable.TipoCuentas.FindAsync(userid);
            return Ok(usergetByUSERID);
        }
    }
}
