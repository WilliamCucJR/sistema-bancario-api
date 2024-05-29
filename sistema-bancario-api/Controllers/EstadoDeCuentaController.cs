using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;
using System.Collections.Generic;
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

        [HttpGet("GetEstadoDeCuenta")]
        public async Task<ActionResult<object>> GetEstadoDeCuenta(string numeroCuenta, int mes)
        {
            var estadoDeCuenta = await _context.EstadosDeCuenta
                .Include(e => e.CuentaBancaria)
                .Include(e => e.Movimientos)
                .Where(e => e.CuentaBancaria.NO_DE_CUENTA == numeroCuenta && e.Mes == mes)
                .Select(e => new
                {
                    e.CuentaBancaria.NO_DE_CUENTA,
                    e.Mes,
                    e.Anio,
                    Movimientos = e.Movimientos.Select(m => new
                    {
                        m.Descripcion,
                        m.NumeroDocumento,
                        TipoDocumento = m.TipoOperacion
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (estadoDeCuenta == null)
            {
                return NotFound();
            }

            return Ok(estadoDeCuenta);
        }
    }
}
