using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [ApiController]
    [Route("bancoAPI/[controller]")]
    public class MovimientosController : ControllerBase
    {
        private readonly MovimientosTable _movimientoTable;

        public MovimientosController(MovimientosTable MovTable)
        {
            _movimientoTable = MovTable;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var userLoginGet = await _movimientoTable.Moves.ToListAsync();
            return Ok(userLoginGet);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(MOVIMIENTOS log)
        {
            var userLoginPost = await _movimientoTable.Moves.AddAsync(log);
            await _movimientoTable.SaveChangesAsync();
            return Ok("El registro se inserto correctamente!");
        }



        [HttpPut]
        public async Task<IActionResult> PutAsync(MOVIMIENTOS log)
        {
            _movimientoTable.Moves.Update(log);
            await _movimientoTable.SaveChangesAsync();
            return NoContent();
        }

        [Route("{USERID}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int USERID)
        {
            var userLoginDelete = await _movimientoTable.Moves.FindAsync(USERID);
            if (userLoginDelete == null)
            {
                return NotFound();
            }

            _movimientoTable.Moves.Remove(userLoginDelete);
            await _movimientoTable.SaveChangesAsync();
            return Ok("El registro se elimino de manera correcta");
        }

        [Route("getuserbyid/{userid}")]
        [HttpGet]
        public async Task<IActionResult> getByUSERID(int userid)
        {
            var usergetByUSERID = await _movimientoTable.Moves.FindAsync(userid);
            return Ok(usergetByUSERID);
        }
    }
}
