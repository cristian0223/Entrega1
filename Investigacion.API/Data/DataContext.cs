using Microsoft.EntityFrameworkCore;
using Investigacion.Shared.Entities;




namespace Investigacion.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext>options):base(options) { }  


        public DbSet<ProyectoInvestigacion> ProyectoInvestigacions {  get; set; }

        public DbSet<Investigadore> Investigadores { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProyectoInvestigacion>().HasIndex(c => c.Nombre).IsUnique();
            modelBuilder.Entity<Investigadore>().HasIndex(c => c.NombreInvestiigadores).IsUnique();
        }

    }
}
