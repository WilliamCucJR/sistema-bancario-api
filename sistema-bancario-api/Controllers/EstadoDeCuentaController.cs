using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;
using System;
using System.Linq;

namespace sistema_bancario_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadoDeCuentaController : ControllerBase
    {
        private readonly EstadoDeCuentaTable _estadoDeCuentaTable;

        public EstadoDeCuentaController(EstadoDeCuentaTable estadoDeCuentaTable)
        {
            _estadoDeCuentaTable = estadoDeCuentaTable;
        }

        [HttpGet]
        public IActionResult GetEstadoDeCuenta(int numeroCuenta, int mes)
        {
            var estadoDeCuenta = _estadoDeCuentaTable.EstadosDeCuenta
                .Include(e => e.Movimientos)
                .FirstOrDefault(e => e.ID_CUENTA == numeroCuenta && e.Mes == mes);

            if (estadoDeCuenta != null)
            {
                var movimientos = estadoDeCuenta.Movimientos
                    .Select(m => new
                    {
                        Descripcion = m.Descripcion,
                        NumeroDocumento = m.NumeroDocumento,
                        TipoOperacion = m.TipoOperacion
                    });

                return Ok(movimientos);
            }
            else
            {
                return NotFound($"No se encontró el estado de cuenta para la cuenta #{numeroCuenta} en el mes {mes}");
            }
        }
    }
}
