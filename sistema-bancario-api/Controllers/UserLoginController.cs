namespace sistema_bancario_api.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

[ApiController]
[Route("api/[controller]")]
public class UserLoginController : ControllerBase
{
    private readonly UserLoginTable _userLoginTable;
    public UserLoginController(UserLoginTable userLoginTable)
    {
        _userLoginTable = userLoginTable;
    }

    [HttpGet("GetAllUserLogins")]
    public async Task<ActionResult<IEnumerable<USERLOGIN>>> GetUserLogins()
    {
        return await _userLoginTable.Logins.FromSqlRaw("SELECT * FROM USERLOGIN ORDER BY USERID DESC").ToListAsync();
    }

    [HttpGet("GetUserLogin/{id}")]
    public async Task<ActionResult<USERLOGIN>> GetUserLogin(int id)
    {

        var userLogin = await _userLoginTable.Logins.FromSqlRaw($"SELECT * FROM USERLOGIN WHERE USERID = {id}").FirstOrDefaultAsync();

        if (userLogin == null)
        {
            return NotFound();
        }

        return userLogin;
    }

    [HttpPost("CreateUserLogin")]
    public async Task<ActionResult<USERLOGIN>> PostUserLogin(USERLOGIN log)
    {
        string consulta = "INSERT INTO USERLOGIN (NICKNAME, PASSWORD, PRIMER_NOMBRE, " +
        "PRIMER_APELLIDO, DIRECCION, TELEFONO, EMAIL, FECHANACIMIENTO, " +
        "FECHAREGISTRO, SEGUNDO_NOMBRE, SEGUNDO_APELLIDO, SEXO, DPI, NIT, CELULAR, ZONA, " +
        "ID_DEPARTAMENTO, ID_MUNICIPIO, NIVEL_ACADEMICO, DEPARTAMENTO_SISTEMA, PUESTO, " +
        "FECHA_INGRESO, ESTATUS_USUARIO) VALUES (:nickname, :password, :primernombre, :primerapellido, " +
        ":direccion, :telefono, :email, :fechanacimiento, :fecharegistro, :segundonombre, :segundoapellido, " +
        ":sexo, :dpi, :nit, :celular, :zona, :iddepartamento, :idmunicipio, :nivelacademico, :departamentosistema," +
        ":puesto, :fechaingreso, :estatususuario)";
        var parametros = new OracleParameter[]
        {
                new OracleParameter("nickname", log.NICKNAME),
                new OracleParameter("password", log.PASSWORD),
                new OracleParameter("primernombre", log.PRIMER_NOMBRE),
                new OracleParameter("primerapellido", log.PRIMER_APELLIDO),
                new OracleParameter("direccion", log.DIRECCION),
                new OracleParameter("telefono", log.TELEFONO),
                new OracleParameter("email", log.EMAIL),
                new OracleParameter("fechanacimiento", log.FECHANACIMIENTO),
                new OracleParameter("fecharegistro", log.FECHAREGISTRO),
                new OracleParameter("segundonombre", log.SEGUNDO_NOMBRE),
                new OracleParameter("segundoapellido", log.SEGUNDO_APELLIDO),
                new OracleParameter("sexo", log.SEXO),
                new OracleParameter("dpi", log.DPI),
                new OracleParameter("nit", log.NIT),
                new OracleParameter("celular", log.CELULAR),
                new OracleParameter("zona", log.ZONA),
                new OracleParameter("iddepartamento", log.ID_DEPARTAMENTO),
                new OracleParameter("idmunicipio", log.ID_MUNICIPIO),
                new OracleParameter("nivelacademico", log.NIVEL_ACADEMICO),
                new OracleParameter("departamentosistema", log.DEPARTAMENTO_SISTEMA),
                new OracleParameter("puesto", log.PUESTO),
                new OracleParameter("fechaingreso", log.FECHA_INGRESO),
                new OracleParameter("estatususuario", log.ESTATUS_USUARIO)

        };
        await _userLoginTable.Database.ExecuteSqlRawAsync(consulta, parametros);

        return CreatedAtAction("GetUserLogin", new { id = log.USERID }, new { message = "Usuario Login creado con éxito", log });
    }

 

    [HttpPut("UpdateUserLogin/{id}")]
    public async Task<IActionResult> PutUserLoginc(int id, USERLOGIN log)
    {

        if (id != log.USERID)
        {
            return BadRequest();
        }

        string consulta = "UPDATE USERLOGIN SET NICKNAME = :nickname, PASSWORD = :password, PRIMER_NOMBRE = :primernombre, PRIMER_APELLIDO = :primerapellido, " +
        "DIRECCION = :direccion, TELEFONO = :telefono, EMAIL = :email, FECHANACIMIENTO = :fechanacimiento, FECHAREGISTRO = :fecharegistro, " +
        "SEGUNDO_NOMBRE = :segundonombre, SEGUNDO_APELLIDO = :segundoapellido, SEXO = :sexo, DPI = :dpi, NIT = :nit, CELULAR = :celular, ZONA = :zona," +
        "ID_DEPARTAMENTO = :id_departamento, ID_MUNICIPIO = :id_municipio, NIVEL_ACADEMICO = :nivel_academico, DEPARTAMENTO_SISTEMA = :departamento_sistema, " +
        "PUESTO = :puesto, FECHA_INGRESO = :fechaingreso, ESTATUS_USUARIO = :estatususuario WHERE USERID = :id;";
       var parametros = new OracleParameter[]
        {
                new OracleParameter("nickname", log.NICKNAME),
                new OracleParameter("password", log.PASSWORD),
                new OracleParameter("primernombre", log.PRIMER_NOMBRE),
                new OracleParameter("primerapellido", log.PRIMER_APELLIDO),
                new OracleParameter("direccion", log.DIRECCION),
                new OracleParameter("telefono", log.TELEFONO),
                new OracleParameter("email", log.EMAIL),
                new OracleParameter("fechanacimiento", log.FECHANACIMIENTO),
                new OracleParameter("fecharegistro", log.FECHAREGISTRO),
                new OracleParameter("segundonombre", log.SEGUNDO_NOMBRE),
                new OracleParameter("segundoapellido", log.SEGUNDO_APELLIDO),
                new OracleParameter("sexo", log.SEXO),
                new OracleParameter("dpi", log.DPI),
                new OracleParameter("nit", log.NIT),
                new OracleParameter("celular", log.CELULAR),
                new OracleParameter("zona", log.ZONA),
                new OracleParameter("fechaingreso", log.FECHA_INGRESO),
                new OracleParameter("estatususuario", log.ESTATUS_USUARIO),
                new OracleParameter("id_departamento", log.ID_DEPARTAMENTO),
                new OracleParameter("id_municipio", log.ID_MUNICIPIO),
                new OracleParameter("nivel_academico", log.NIVEL_ACADEMICO),
                new OracleParameter("departamento_sistema", log.DEPARTAMENTO_SISTEMA),
                new OracleParameter("puesto", log.PUESTO),
                new OracleParameter("id", id)

        };
        await _userLoginTable.Database.ExecuteSqlRawAsync(consulta, parametros);

        return Ok(new { message = "Usuario actualizado con éxito" });
    }

    [HttpDelete("DeleteUserLogin/{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        await _userLoginTable.Database.ExecuteSqlRawAsync($"DELETE FROM USERLOGIN WHERE USERID = {id}");

        return Ok(new { message = "Usuario eliminado con éxito" });
    }


}

