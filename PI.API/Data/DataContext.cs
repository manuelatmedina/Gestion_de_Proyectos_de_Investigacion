using Microsoft.EntityFrameworkCore;
using PI.Shared.Entities;
using System.Security.Cryptography.X509Certificates;

namespace PI.API.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
       
                 
        
        }

        //Mapeo de clases para enviarlas a la BD
        public DbSet<Project>Projects { get; set; }
        
        public DbSet<Investigator> Investigators { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
    
}
