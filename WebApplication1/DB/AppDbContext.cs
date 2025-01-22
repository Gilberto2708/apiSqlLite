using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;

namespace WebApplication1.DB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
         
        }

        public DbSet<Entity.Person> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=miDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey(p => p.Id); // Define la clave primaria
        }

    }

}
                                                                                                                              