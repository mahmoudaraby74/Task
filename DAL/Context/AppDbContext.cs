using DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Task.Entites;

namespace Task.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server =. ; database = Task; integrated security = true");
        //}

        public DbSet<Office> Offices { get; set; }
        public DbSet<Client> Clients { get; set; }

        
    }

}
