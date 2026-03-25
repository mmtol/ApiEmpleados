using ApiEmpleados.Models;
using ApiEmpleados.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpleados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empleado>>> GetEmpleados()
        {
            return await repo.GetEmpleadosAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> FindEmpleado(int id)
        {
            return await repo.FindEmpleadoAsync(id);
        }
    }
}
