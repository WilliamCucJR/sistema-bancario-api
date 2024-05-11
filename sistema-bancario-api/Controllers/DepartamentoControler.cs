using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoControler : ControllerBase
    {
        private readonly DepartamentoTable deptotable;

        public DepartamentoControler(DepartamentoTable deptotable)
        {
            this.deptotable = deptotable;
        }

        // GET: api/Movimientos
        [HttpGet("GetAllDepartamentos")]
        public async Task<ActionResult<IEnumerable<DEPARTAMENTO>>> GetDepartamentos()
        {
            return await deptotable.Deptos.FromSqlRaw("SELECT * FROM DEPARTAMENTO ORDER BY NOMBRE_DEL_DEPARTAMENTO ASC").ToListAsync();
        }

        // GET: api/Movimientos/5
        [HttpGet("GetDepartamento/{id}")]
        public async Task<ActionResult<DEPARTAMENTO>> GetDepartamento(int id)
        {
            var dep = await deptotable.Deptos.FromSqlRaw($"SELECT * FROM DEPARTAMENTO WHERE ID = {id}").FirstOrDefaultAsync();

            if (dep == null)
            {
                return NotFound();
            }

            return dep;
        }
    }
}
