using Microsoft.EntityFrameworkCore;
using Lab.Models;

namespace Lab.Data
{
    public class LabContext : DbContext
    {
        public LabContext(DbContextOptions<LabContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=lab.db");
        }

        public DbSet<Persona> Personas { get; set; }

    }
}