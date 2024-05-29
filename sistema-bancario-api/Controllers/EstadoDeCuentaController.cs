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
        public async Task<ActionResult<IEnumerable<object>>> GetEstadoDeCuenta(int noCuenta, string mes)
        {

            var estadoDeCuenta = await _context.EstadoDeCuenta
            .FromSqlRaw(@"SELECT a.ID_MOVIMIENTO, 
                                 a.DESCRIPCION, 
                                 a.FECHA, 
                                 a.NO_DOCUMENTO, 
                                 a.TIPO_DOCUMENTO_ID, 
                                 a.MONTO, 
                                 b.NO_DE_CUENTA, 
                                 c.NOMBRE_DOCUMENTO, 
                                 c.OPERACION
                          FROM MOVIMIENTOS a
                          INNER JOIN CUENTA_BANCARIA b ON b.ID_CUENTA = a.ID_CUENTA
                          INNER JOIN TIPO_DOCUMENTO c ON c.ID = a.TIPO_DOCUMENTO_ID
                          WHERE b.NO_DE_CUENTA = {0} 
                          AND EXTRACT(MONTH FROM a.FECHA) = {1}
                          ORDER BY a.FECHA DESC", noCuenta, mes)
            .Select(m => new
            {
                m.DESCRIPCION,
                m.FECHA,
                m.NO_DOCUMENTO,
                m.MONTO,
                m.NO_DE_CUENTA,
                m.OPERACION,
                m.NOMBRE_DOCUMENTO
            })
            .ToListAsync();

            if (estadoDeCuenta == null)
            {
                return NotFound();
            }

            return estadoDeCuenta;
        }
    }
}
