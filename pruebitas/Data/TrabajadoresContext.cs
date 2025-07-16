using Microsoft.EntityFrameworkCore;
using pruebitas.Models;

namespace pruebitas.Data
{
    public class TrabajadoresContext : DbContext
    {
        public TrabajadoresContext(DbContextOptions<TrabajadoresContext> options) : base(options) { }

        public DbSet<TrabajadorViewModel> TrabajadorViewModel { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }

    }


}
