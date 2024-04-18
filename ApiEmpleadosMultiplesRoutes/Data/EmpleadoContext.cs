
using Microsoft.EntityFrameworkCore;
using NugetApiModels.Models;

namespace ApiEmpleadosMultiplesRoutes.Data
{
    public class EmpleadoContext:DbContext
    {
        public EmpleadoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }

    }
}
