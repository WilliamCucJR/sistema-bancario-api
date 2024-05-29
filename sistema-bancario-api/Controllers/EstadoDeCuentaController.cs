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

        [HttpGet("GetEstadoDeCuenta/{numeroCuenta}/{mes}")]
        public async Task<ActionResult<IEnumerable<object>>> GetEstadoDeCuenta(string numeroCuenta, int mes)
        {
            var movimientos = await _context.MovimientosEstadoCuenta
                .FromSqlRaw($@"
                    SELECT 
                        m.Descripcion, 
                        m.NoDocumento AS NumeroDocumento, 
                        CASE 
                            WHEN m.TipoDocumentoID = 1 THEN 'Debito'
                            ELSE 'Credito'
                        END AS TipoOperacion
                    FROM MOVIMIENTOS m
                    INNER JOIN CUENTA_BANCARIA c ON m.ID_CUENTA = c.ID_CUENTA
                    WHERE c.NO_DE_CUENTA = {numeroCuenta} 
                        AND EXTRACT(MONTH FROM TO_DATE(m.Fecha, 'YYYY-MM-DD')) = {mes}")
                .ToListAsync();

            if (movimientos == null || !movimientos.Any())
            {
                return NotFound();
            }

            return Ok(movimientos);
        }
    }
}
