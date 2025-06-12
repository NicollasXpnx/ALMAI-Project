using Microsoft.EntityFrameworkCore;
using PacientesALMAI.Models;

namespace PacientesALMAI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Terapia> Terapias { get; set; }
    }
}
