using ApiEmpleados.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiEmpleados.Data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext(DbContextOptions<EmpleadosContext> options) : base(options) { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
