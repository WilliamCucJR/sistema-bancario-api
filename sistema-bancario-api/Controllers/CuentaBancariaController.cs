using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaBancariaController : ControllerBase
    {
        private readonly CuentaBancariaTable _ctaBancaria;

        public CuentaBancariaController(CuentaBancariaTable ctaBanc)
        {
            _ctaBancaria = ctaBanc;
        }

        [HttpGet("GetAllCuentasBancarias")]
        public async Task<ActionResult<IEnumerable<CUENTA_BANCARIA>>> getCuentasBancarias()
        {
            return await _ctaBancaria.Bancs.FromSqlRaw("SELECT * FROM CUENTA_BANCARIA ORDER BY ID_CUENTA DESC").ToListAsync();
        }

        [HttpGet("GetCuentaBancaria/{id}")]
        public async Task<ActionResult<CUENTA_BANCARIA>> GetCuentaBancaria(int id)
        {
            var ctabancs = await _ctaBancaria.Bancs.FromSqlRaw($"SELECT * FROM CUENTA_BANCARIA WHERE ID_CUENTA = {id}").FirstOrDefaultAsync();

            if (ctabancs == null)
            {
                return NotFound();
            }

            return ctabancs;
        }

        [HttpGet("GetCuentaBancariaByNoCuenta/{noCuenta}")]
        public async Task<ActionResult<CUENTA_BANCARIA>> GetCuentaBancariaByNoCuenta(string noCuenta)
        {
            var ctabancs = await _ctaBancaria.Bancs.FromSqlRaw($"SELECT * FROM CUENTA_BANCARIA WHERE NO_DE_CUENTA = {noCuenta}").FirstOrDefaultAsync();

            if (ctabancs == null)
            {
                return NotFound();
            }

            return ctabancs;
        }

        [HttpGet("GetCuentaBancariaByBancoID/{idbanco}")]
        public async Task<ActionResult<IEnumerable<CUENTA_BANCARIA>>> GetCuentaBancariaByBancoID(int idbanco)
        {
            return await _ctaBancaria.Bancs.FromSqlRaw($"SELECT * FROM CUENTA_BANCARIA WHERE BANCO_ID = {idbanco}").ToListAsync();
        }

        [HttpPost("CreateCuentaBancaria")]
        public async Task<ActionResult<CUENTA_BANCARIA>> PostCuentaBancaria(CUENTA_BANCARIA cuenta)
        {
            string consulta = "INSERT INTO CUENTA_BANCARIA (BANCO_ID, NO_DE_CUENTA, TIPO_DE_CUENTA_ID, NOMBRE_CUENTAHABIENTE, DPI, NIT, TELEFONO, CORREO," +
                "DIRECCION, ZONA, DEPARTAMENTO_ID, MUNICIPIO_ID, MONEDA_ID, SALDO) VALUES (:bancoid, :nodecuenta, :tipodecuentaid, :nombrecuentahabiente, " +
                ":dpi, :nit, :telefono, :correo, :direccion, :zona, :departamentoid, :municipioid, :monedaid, :saldo)";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("bancoid", cuenta.BANCO_ID),
                new OracleParameter("nodecuenta", cuenta.NO_DE_CUENTA),
                new OracleParameter("tipodecuentaid", cuenta.TIPO_DE_CUENTA_ID),
                new OracleParameter("nombrecuentahabiente", cuenta.NOMBRE_CUENTAHABIENTE),
                new OracleParameter("dpi", cuenta.DPI),
                new OracleParameter("nit", cuenta.NIT),
                new OracleParameter("telefono", cuenta.TELEFONO),
                new OracleParameter("correo", cuenta.CORREO),
                new OracleParameter("direccion", cuenta.DIRECCION),
                new OracleParameter("zona", cuenta.ZONA),
                new OracleParameter("departamentoid", cuenta.DEPARTAMENTO_ID),
                new OracleParameter("municipioid", cuenta.MUNICIPIO_ID),
                new OracleParameter("monedaid", cuenta.MONEDA_ID),
                new OracleParameter("saldo", cuenta.SALDO)
            };
            await _ctaBancaria.Database.ExecuteSqlRawAsync(consulta, parametros);

            return CreatedAtAction("GetCuentaBancaria", new { id = cuenta.ID_CUENTA }, new { message = "Cuenta bancaria creada con éxito", cuenta });
        }

        [HttpPut("UpdateCuentaBancaria/{id}")]
        public async Task<IActionResult> PutCuentaBancaria(int id, CUENTA_BANCARIA cuenta)
        {
            if (id != cuenta.ID_CUENTA)
            {
                return BadRequest();
            }

            string consulta = "UPDATE CUENTA_BANCARIA SET BANCO_ID = :bancoid, NO_DE_CUENTA = :nodecuenta, TIPO_DE_CUENTA_ID = :tipodecuentaid, NOMBRE_CUENTAHABIENTE = :nombrecuentahabiente, DPI = :dpi, " +
                "NIT = :nit, TELEFONO = :telefono, CORREO = :correo, DIRECCION = :direccion, ZONA = :zona, DEPARTAMENTO_ID = :departamentoid, " +
                "MUNICIPIO_ID = :municipioid, MONEDA_ID = :monedaid, SALDO = :saldo WHERE ID_CUENTA = :id";
            var parametros = new OracleParameter[]
            {
                new OracleParameter("bancoid", cuenta.BANCO_ID),
                new OracleParameter("nodecuenta", cuenta.NO_DE_CUENTA),
                new OracleParameter("tipodecuentaid", cuenta.TIPO_DE_CUENTA_ID),
                new OracleParameter("nombrecuentahabiente", cuenta.NOMBRE_CUENTAHABIENTE),
                new OracleParameter("dpi", cuenta.DPI),
                new OracleParameter("nit", cuenta.NIT),
                new OracleParameter("telefono", cuenta.TELEFONO),
                new OracleParameter("correo", cuenta.CORREO),
                new OracleParameter("direccion", cuenta.DIRECCION),
                new OracleParameter("zona", cuenta.ZONA),
                new OracleParameter("departamentoid", cuenta.DEPARTAMENTO_ID),
                new OracleParameter("municipioid", cuenta.MUNICIPIO_ID),
                new OracleParameter("monedaid", cuenta.MONEDA_ID),
                new OracleParameter("saldo", cuenta.SALDO),
                new OracleParameter("id", id)
            };
            await _ctaBancaria.Database.ExecuteSqlRawAsync(consulta, parametros);

            return Ok(new { message = "Cuenta bancaria actualizada con éxito" });
        }

        [HttpDelete("DeleteCuentaBancaria/{id}")]
        public async Task<IActionResult> DeleteCuentaBancaria(int id)
        {
            await _ctaBancaria.Database.ExecuteSqlRawAsync($"DELETE FROM CUENTA_BANCARIA WHERE ID_CUENTA = {id}");

            return Ok(new { message = "Cuenta bancaria eliminada con éxito" });
        }
    }
}
