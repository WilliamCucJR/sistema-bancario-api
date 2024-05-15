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
    public class ConciliacionController : ControllerBase
    {
        private readonly ConciliacionTable _context;

        public ConciliacionController(ConciliacionTable context)
        {
            _context = context;
        }

        [HttpGet("GetConciliacion/{noCuenta}/{idBanco}/{mes}/{anio}")]
        public async Task<ActionResult<IEnumerable<object>>> GetConciliacion(int noCuenta, int idBanco, int mes, int anio)
        {
            var conciliacion = await _context.Conciliacion
                .FromSqlRaw($"SELECT a.ID_MOVIMIENTO, a.ID_CUENTA, a.ID_DOCUMENTO, a.DESCRIPCION, a.FECHA, " +
                            $"a.NO_DOCUMENTO, a.TIPO_DOCUMENTO_ID, a.MONTO, a.DOCUMENTO_CONTABLE, b.NO_DE_CUENTA, c.OPERACION " +
                            $"FROM MOVIMIENTOS a " +
                            $"INNER JOIN CUENTA_BANCARIA b ON b.ID_CUENTA = a.ID_CUENTA " +
                            $"INNER JOIN TIPO_DOCUMENTO c ON c.ID = a.ID_DOCUMENTO " +
                            $"WHERE b.NO_DE_CUENTA = {noCuenta} AND b.BANCO_ID = {idBanco} " +
                            $"AND (EXTRACT(YEAR FROM FECHA) = {anio} AND EXTRACT(MONTH FROM FECHA) = {mes})")
                .Select(m => new
                {
                    DESCRIPCION = m.DESCRIPCION,
                    FECHA = m.FECHA,
                    NO_DOCUMENTO = m.NO_DOCUMENTO,
                    MONTO = m.MONTO,
                    NO_DE_CUENTA = m.NO_DE_CUENTA,
                    OPERACION = m.OPERACION
                })
                .ToListAsync();

            if (conciliacion == null)
            {
                return NotFound();
            }

            return conciliacion;
        }
    }
}
