using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logs;
using Microsoft.EntityFrameworkCore;

namespace CarTracker.WebMvcApp.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<RepairLog> RepairLog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("");
        }
    }
}
