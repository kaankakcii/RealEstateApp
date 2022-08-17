
using Microsoft.EntityFrameworkCore;
using RealEstateApp.Models;

namespace RealEstateApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<InstitutionalUser> InstitutionalUsers { get; set; }
    }
}
