
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Models;

namespace RealEstateApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            

        }

        public DbSet<User> User { get; set; }
        public DbSet<InstitutionalUser> InstitutionalUser { get; set; }
    }
}
