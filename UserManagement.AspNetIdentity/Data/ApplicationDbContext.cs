using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagement.AspNetIdentity.Models.Domain;

namespace UserManagement.AspNetIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>(entity => {
                entity.ToTable(name: "Users");
            });

            builder.Entity<IdentityRole>(entity => {
                entity.ToTable(name: "Roles");
            });

            builder.Entity<IdentityUserRole<string>>(entity => {
                entity.ToTable("UserRoles");
            });

            builder.Entity<IdentityUserClaim<string>>(entity => {
                entity.ToTable("UserClaims");
            });




            builder.Entity<IdentityUserLogin<string>>(entity => {
                entity.ToTable("UserLogins");
            });


            builder.Entity<IdentityRoleClaim<string>>(entity => {
                entity.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserToken<string>>(entity => {
                entity.ToTable("UserTokens");
            });
        }
    }
}
