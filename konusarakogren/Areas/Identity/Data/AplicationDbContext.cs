using DataLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace konusarakogren.Areas.Identity.Data
{
    public class AplicationDbContext: AplicationDbContext<User>
    {
        public AplicationDbContext(DbContextOptions<Context> options): base(options)
        {
        }
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }
}

