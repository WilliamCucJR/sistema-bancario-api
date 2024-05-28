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
    public class CashFlowController : ControllerBase
    {
        private readonly CashFlowTable cashf;

        public CashFlowController(CashFlowTable cashf)
        {
            this.cashf = cashf;
        }

        [HttpGet("GetReportCashFlow")]
        public async Task<ActionResult<IEnumerable<object>>> GetConciliacion()
        {
            var conciliacion = await cashf.cashF
                .FromSqlRaw($"SELECT a.NO_DE_CUENTA, b.NOMBRE_BANCO, c.TIPO_DE_CUENTA, a.SALDO " +
                            $"FROM CUENTA_BANCARIA a " +
                            $"INNER JOIN BANCO b ON a.BANCO_ID = b.ID_BANCO " +
                            $"INNER JOIN TIPO_CUENTA c ON a.TIPO_DE_CUENTA_ID = c.ID " +
                            $"ORDER BY b.NOMBRE_BANCO, a.SALDO DESC")
                .ToListAsync();

            if (conciliacion == null)
            {
                return NotFound();
            }

            return conciliacion;
        }
    }
}
