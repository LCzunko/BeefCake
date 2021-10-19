using BeefCakeData.DAL;
using BeefCakeData.Model;
using Microsoft.EntityFrameworkCore;

namespace BeefCakeData
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedBeefCake();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BeefCakeDB;Trusted_Connection=True;");
        }
    }
}
