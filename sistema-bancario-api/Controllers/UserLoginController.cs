namespace sistema_bancario_post.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_post.Data;
using sistema_bancario_post.Data.Entities.Login;

[ApiController]
[Route("analisis1/[controller]")]
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
        return Ok(userLoginPost.Entity);
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
        return NoContent();
    }

    [Route("getuserbyid")]
    [HttpGet]
    public async Task<IActionResult> getByUSERID(int userid)
    {
        var usergetByUSERID = await _userLoginTable.Logins.FindAsync(userid);
        return Ok(usergetByUSERID);
    }


}

