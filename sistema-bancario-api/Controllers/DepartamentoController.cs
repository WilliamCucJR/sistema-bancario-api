using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [ApiController]
    [Route("bancoAPI/[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly DepartamentoTable _deptoTable;
        public DepartamentoController(DepartamentoTable deptotable)
        {
            _deptoTable = deptotable;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var deptoTableGet = await _deptoTable.Deptos.ToListAsync();
            return Ok(deptoTableGet);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(DEPARTAMENTO log)
        {
            var userLoginPost = await _deptoTable.Deptos.AddAsync(log);
            await _deptoTable.SaveChangesAsync();
            return Ok("El registro se inserto correctamente!");
        }



        [HttpPut]
        public async Task<IActionResult> PutAsync(DEPARTAMENTO log)
        {
            _deptoTable.Deptos.Update(log);
            await _deptoTable.SaveChangesAsync();
            return NoContent();
        }

        [Route("{USERID}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int USERID)
        {
            var userLoginDelete = await _deptoTable.Deptos.FindAsync(USERID);
            if (userLoginDelete == null)
            {
                return NotFound();
            }

            _deptoTable.Deptos.Remove(userLoginDelete);
            await _deptoTable.SaveChangesAsync();
            return Ok("El registro se elimino de manera correcta");
        }

        [Route("getuserbyid/{userid}")]
        [HttpGet]
        public async Task<IActionResult> getByUSERID(int userid)
        {
            var usergetByUSERID = await _deptoTable.Deptos.FindAsync(userid);
            return Ok(usergetByUSERID);
        }
    }
}
