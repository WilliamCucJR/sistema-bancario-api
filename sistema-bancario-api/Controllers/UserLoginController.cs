namespace sistema_bancario_api.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

[ApiController]
[Route("bancoAPI/[controller]")]
public class UserLoginController : ControllerBase
{
    private readonly UserLoginTable _userLoginTable;
    public UserLoginController(UserLoginTable userLoginTable)
    {
        _userLoginTable = userLoginTable;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var userLoginGet = await _userLoginTable.Logins.ToListAsync();
        return Ok(userLoginGet);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(USERLOGIN log)
    {
        var userLoginPost = await _userLoginTable.Logins.AddAsync(log);
        await _userLoginTable.SaveChangesAsync();
        return Ok("El registro se inserto correctamente!");
    }

 

    [HttpPut]
    public async Task<IActionResult> PutAsync(USERLOGIN log)
    {
        _userLoginTable.Logins.Update(log);
        await _userLoginTable.SaveChangesAsync();
        return NoContent();
    }

    [Route("{USERID}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int USERID)
    {
        var userLoginDelete = await _userLoginTable.Logins.FindAsync(USERID);
        if (userLoginDelete == null)
        {
            return NotFound();
        }

        _userLoginTable.Logins.Remove(userLoginDelete);
        await _userLoginTable.SaveChangesAsync();
        return Ok("El registro se elimino de manera correcta");
    }

    [Route("getuserbyid/{userid}")]
    [HttpGet]
    public async Task<IActionResult> getByUSERID(int userid)
    {
        var usergetByUSERID = await _userLoginTable.Logins.FindAsync(userid);
        return Ok(usergetByUSERID);
    }


}

