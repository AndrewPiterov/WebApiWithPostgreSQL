using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApiWitnPostgreSQL.Models;

namespace WebApiWitnPostgreSQL.DbContexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("accounts")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("users", "membership");
            modelBuilder.Entity<IdentityRole>().ToTable("roles", "membership");
            modelBuilder.Entity<IdentityUserRole>().ToTable("user_role", "membership");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("claims", "membership");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("logins", "membership");
        }
    }
}