using System.Data.Entity.ModelConfiguration;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApiWitnPostgreSQL.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    //public class UserConfig : EntityTypeConfiguration<ApplicationUser>
    //{
    //    public UserConfig()
    //    {
    //        ToTable("users", "membership");

    //        HasKey(x => x.Id);
    //        Property(x => x.Id).HasColumnName("user_id");
    //        Property(x => x.Email).HasColumnName("email");
    //        Property(x => x.PhoneNumber).HasColumnName("phone_number");
    //    }
    //}
}