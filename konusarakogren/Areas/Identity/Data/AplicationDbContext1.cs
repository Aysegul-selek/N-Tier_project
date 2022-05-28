using DataLayer.Concreate;
using Microsoft.EntityFrameworkCore;

namespace konusarakogren.Areas.Identity.Data
{
    public class AplicationDbContext<T>
    {
        private DbContextOptions<Context> options;

        public AplicationDbContext(DbContextOptions<Context> options)
        {
            this.options = options;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }

        internal void OnModelCreating(ModelBuilder builder)
        {
            throw new NotImplementedException();
        }
    }
}