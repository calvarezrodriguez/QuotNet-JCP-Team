using Microsoft.EntityFrameworkCore;
using Cotizaciones.Models;

namespace Cotizaciones.Data {
    public class CotizacionesContext : DbContext {
        public CotizacionesContext(DbContextOptions<CotizacionesContext> options) : base(options){
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            /// utilizacion SqLite como backend
            optionsBuilder.UseSqlite("Data Source = cotizaciones.db");
        }
        public DbSet<Persona> Personas {get; set;}
        //public DbSet<Persona> Cotizaciones {get; set;}

        public DbSet<Cotizacion> Cotizaciones {get; set;}
        public DbSet<CotizacionPersona> CotizacionPersonas {get; set; }
    }
}