using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [ApiController]
    [Route("bancoAPI/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly BancoTable _bancoTable;

        public BancoController(BancoTable bancoTable)
        {
            _bancoTable = bancoTable;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var monedaTableGet = await _bancoTable.bancos.ToListAsync();
            return Ok(monedaTableGet);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(BANCO log)
        {
            var userLoginPost = await _bancoTable.bancos.AddAsync(log);
            await _bancoTable.SaveChangesAsync();
            return Ok("El registro se inserto correctamente!");
        }



        [HttpPut]
        public async Task<IActionResult> PutAsync(BANCO log)
        {
            _bancoTable.bancos.Update(log);
            await _bancoTable.SaveChangesAsync();
            return NoContent();
        }

        [Route("{USERID}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int USERID)
        {
            var userLoginDelete = await _bancoTable.bancos.FindAsync(USERID);
            if (userLoginDelete == null)
            {
                return NotFound();
            }

            _bancoTable.bancos.Remove(userLoginDelete);
            await _bancoTable.SaveChangesAsync();
            return Ok("El registro se elimino de manera correcta");
        }

        [Route("getuserbyid/{userid}")]
        [HttpGet]
        public async Task<IActionResult> getByUSERID(int userid)
        {
            var usergetByUSERID = await _bancoTable.bancos.FindAsync(userid);
            return Ok(usergetByUSERID);
        }
    }
}
