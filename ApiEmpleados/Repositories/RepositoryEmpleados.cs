using ApiEmpleados.Data;
using ApiEmpleados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpleados.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public async Task<List<Empleado>> GetEmpleadosAsync()
        {
            return await context.Empleados.ToListAsync();
        }

        public async Task<Empleado> FindEmpleadoAsync(int id)
        {
            return await context.Empleados.FirstOrDefaultAsync(z => z.IdEmpleado == id);
        }
    }
}
