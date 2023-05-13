using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZeelandZoo.Areas.Identity.Data
{
    public class ZealandZooUsersIdentityContext : IdentityDbContext<Student>
    {
        public ZealandZooUsersIdentityContext(DbContextOptions<ZealandZooUsersIdentityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }


    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(u => u.Fornavn).HasMaxLength(255);
            builder.Property(u => u.Efternavn).HasMaxLength(255);
        }
    }
}