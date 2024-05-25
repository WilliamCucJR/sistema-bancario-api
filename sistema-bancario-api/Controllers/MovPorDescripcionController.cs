using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovPorDescripcionController : ControllerBase
    {
        private readonly MovPorDescripcionTable _context;

        public MovPorDescripcionController(MovPorDescripcionTable context)
        {
            _context = context;
        }

        [HttpGet("GetReportMovPorDescripcion/{fecha}")]
        public async Task<ActionResult<IEnumerable<object>>> GetConciliacion(string fecha)
        {
            var conciliacion = await _context.MovPorDesc
                .FromSqlRaw($"SELECT a.DESCRIPCION, SUM(a.MONTO) AS MONTO, b.OPERACION " +
                            $"FROM MOVIMIENTOS a " +
                            $"INNER JOIN TIPO_DOCUMENTO b ON a.TIPO_DOCUMENTO_ID = b.ID " +
                            $"WHERE TO_CHAR(FECHA, 'MM') = '{fecha}' " +
                            $"GROUP BY a.DESCRIPCION, b.OPERACION")               
                .ToListAsync();

            if (conciliacion == null)
            {
                return NotFound();
            }

            return conciliacion;
        }
    }
}
