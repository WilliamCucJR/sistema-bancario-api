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
    public class TotalDebitosXCuentaController : ControllerBase
    {
        private readonly TotalDebitosXCuentaTable tt;

        public TotalDebitosXCuentaController(TotalDebitosXCuentaTable tt)
        {
            this.tt = tt;
        }

        [HttpGet("GetReportTotalDebitosXCuenta/{fecha}")]
        public async Task<ActionResult<IEnumerable<object>>> GetConciliacion(string fecha)
        {
            var conciliacion = await tt.TotDebs
                .FromSqlRaw($"SELECT CB.NO_DE_CUENTA, B.NOMBRE_BANCO, SUM(M.MONTO) AS TOTAL_DEBITOS " +
                            $"FROM MOVIMIENTOS M " +
                            $"INNER JOIN TIPO_DOCUMENTO TD ON M.TIPO_DOCUMENTO_ID = TD.ID " +
                            $"INNER JOIN CUENTA_BANCARIA CB ON M.ID_CUENTA = CB.ID_CUENTA " +
                            $"INNER JOIN BANCO B ON CB.BANCO_ID = B.ID_BANCO " +
                            $"WHERE TD.OPERACION = -1 AND TO_CHAR(M.FECHA, 'MM') = '{fecha}' " +
                            $"GROUP BY CB.NO_DE_CUENTA, B.NOMBRE_BANCO " +
                            $"ORDER BY CB.NO_DE_CUENTA")
                .ToListAsync();

            if (conciliacion == null)
            {
                return NotFound();
            }

            return conciliacion;
        }
    }
}
