using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sistema_bancario_api.Data;
using sistema_bancario_api.Data.Entities.Table;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace sistema_bancario_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private readonly MunicipioTable municipioTable1;

        public MunicipioController(MunicipioTable municipioTable)
        {
            this.municipioTable1 = municipioTable;
        }

        // GET: api/Municipios
        [HttpGet("GetAllMunicipios")]
        public async Task<ActionResult<IEnumerable<Municipio>>> GetDepartamentos()
        {
            return await municipioTable1.Municipios.FromSqlRaw("SELECT * FROM Municipio ORDER BY NOMBRE_DEL_MUNICIPIO ASC").ToListAsync();
        }

        // GET: api/Municipio/GetMunicipiosByDepartamento/5
        [HttpGet("GetMunicipiosByDepartamento/{departamentoId}")]
        public async Task<ActionResult<IEnumerable<Municipio>>> GetMunicipiosByDepartamento(int departamentoId)
        {
            var municipios = await municipioTable1.Municipios
                .FromSqlInterpolated($"SELECT * FROM Municipio WHERE ID_Departamento = {departamentoId}")
                .ToListAsync();

            if (municipios == null)
            {
                return NotFound();
            }

            return municipios;
        }
    }
}
