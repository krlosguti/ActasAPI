using Microsoft.EntityFrameworkCore;
using ActasAPI.Models;

namespace  ActasAPI.Data
{
    public class ActasDBContext:DbContext
    {
        public ActasDBContext(DbContextOptions<ActasDBContext> options):base(options)
        {

        }

        public DbSet<Acta> Actas { get; set; }
        public DbSet<Compromiso> Compromisos { get; set; }
        public DbSet<Avance> Avances { get; set; }
        public DbSet<Responsable> Responsables { get; set; }
    }
}
