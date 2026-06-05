using Microsoft.EntityFrameworkCore;
using RegistrationPortal.Api.Models;

namespace RegistrationPortal.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}


