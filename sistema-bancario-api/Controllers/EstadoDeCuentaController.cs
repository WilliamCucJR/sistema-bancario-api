using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoDeCuentaController : ControllerBase
    {
        private readonly EstadoDeCuentaTable _context;

        public EstadoDeCuentaController(EstadoDeCuentaTable context)
        {
            _context = context;
        }

        [HttpGet("{noCuenta}/{mes}")]
        public async Task<ActionResult<IEnumerable<object>>> GetEstadoDeCuenta(int noCuenta, int mes)
        {
            try
            {
                var estadoDeCuenta = await _context.EstadoDeCuenta
                    .FromSqlRaw($"SELECT a.NUMERO_DOCUMENTO, a.DESCRIPCION, a.MONTO, a.TIPO_DOCUMENTO, a.OPERACION " +
                                 $"FROM ESTADODECUENTA a " +
                                 $"WHERE a.NO_DE_CUENTA = {noCuenta} AND " +
                                 $"EXTRACT(MONTH FROM a.FECHA) = {mes} AND " +
                                 $"EXTRACT(YEAR FROM a.FECHA) = {DateTime.Now.Year} " +
                                 $"ORDER BY a.FECHA DESC")
                    .ToListAsync();

                if (estadoDeCuenta == null || !estadoDeCuenta.Any())
                {
                    return NotFound("No se encontraron movimientos para la cuenta especificada en el mes y año actual.");
                }

                return Ok(estadoDeCuenta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }
    }
}
