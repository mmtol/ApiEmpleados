using ApiEmpleados.Data;
using Microsoft.EntityFrameworkCore;
using NugetApiModelsMMT.Models;

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

        public async Task<List<string>> GetOficiosAsync()
        {
            var consulta = (from datos in context.Empleados
                            select datos.Oficio).Distinct();
            return await consulta.ToListAsync();
        }

        public async Task<List<Empleado>> GetEmpleadosOficioAsync(string oficio)
        {
            return await context.Empleados.Where(x => x.Oficio == oficio).ToListAsync();
        }

        public async Task<List<Empleado>> GetEmpleadosSalarioDepartamentoAsync(int salario, int departamento)
        {
            return await context.Empleados.Where(x => x.Salario >= salario && x.Departamento == departamento).ToListAsync();
        }
    }
}
