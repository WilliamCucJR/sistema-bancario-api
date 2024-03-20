using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;


namespace sistema_bancario_api.Controllers
{
    [ApiController]
    [Route("bancoAPI/[controller]")]
    public class MunicipioController : ControllerBase
    {
        private readonly MunicipioTable _muniTable;
        public MunicipioController(MunicipioTable munitable)
        {
            _muniTable = munitable;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var muniTableGet = await _muniTable.Munis.ToListAsync();
            return Ok(muniTableGet);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(MUNICIPIO log)
        {
            var muniPost = await _muniTable.Munis.AddAsync(log);
            await _muniTable.SaveChangesAsync();
            return Ok("El registro se inserto correctamente!");
        }



        [HttpPut]
        public async Task<IActionResult> PutAsync(MUNICIPIO log)
        {
            _muniTable.Munis.Update(log);
            await _muniTable.SaveChangesAsync();
            return NoContent();
        }

        [Route("{USERID}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int USERID)
        {
            var userLoginDelete = await _muniTable.Munis.FindAsync(USERID);
            if (userLoginDelete == null)
            {
                return NotFound();
            }

            _muniTable.Munis.Remove(userLoginDelete);
            await _muniTable.SaveChangesAsync();
            return Ok("El registro se elimino de manera correcta");
        }

        [Route("getuserbyid/{userid}")]
        [HttpGet]
        public async Task<IActionResult> getByUSERID(int userid)
        {
            var usergetByUSERID = await _muniTable.Munis.FindAsync(userid);
            return Ok(usergetByUSERID);
        }
    }
}
