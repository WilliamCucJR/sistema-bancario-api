using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{

    [ApiController]
    [Route("bancoAPI/[controller]")]

    public class MonedaController : ControllerBase
    {

        private readonly MonedaTable _monedaTable;
        public MonedaController(MonedaTable monedatable)
        {
            _monedaTable = monedatable;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var monedaTableGet = await _monedaTable.Monedas.ToListAsync();
            return Ok(monedaTableGet);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(MONEDA log)
        {
            var userLoginPost = await _monedaTable.Monedas.AddAsync(log);
            await _monedaTable.SaveChangesAsync();
            return Ok("El registro se inserto correctamente!");
        }



        [HttpPut]
        public async Task<IActionResult> PutAsync(MONEDA log)
        {
            _monedaTable.Monedas.Update(log);
            await _monedaTable.SaveChangesAsync();
            return NoContent();
        }

        [Route("{USERID}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int USERID)
        {
            var userLoginDelete = await _monedaTable.Monedas.FindAsync(USERID);
            if (userLoginDelete == null)
            {
                return NotFound();
            }

            _monedaTable.Monedas.Remove(userLoginDelete);
            await _monedaTable.SaveChangesAsync();
            return Ok("El registro se elimino de manera correcta");
        }

        [Route("getuserbyid/{userid}")]
        [HttpGet]
        public async Task<IActionResult> getByUSERID(int userid)
        {
            var usergetByUSERID = await _monedaTable.Monedas.FindAsync(userid);
            return Ok(usergetByUSERID);
        }
    }
}
