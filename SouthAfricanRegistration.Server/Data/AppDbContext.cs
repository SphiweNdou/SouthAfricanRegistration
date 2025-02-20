using Microsoft.EntityFrameworkCore;
using SouthAfricanRegistration.Server.Models;

namespace SouthAfricanRegistration.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
    }
}
