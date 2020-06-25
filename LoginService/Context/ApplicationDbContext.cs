using LoginService.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LoginService.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<IdentityUserClaim<string>> identityUserClaims { get; set; }
        public DbSet<IdentityUserRole<string>> identityUserRoles { get; set; }
        public DbSet<IdentityRole> identityRoles{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
        }
    }
}
