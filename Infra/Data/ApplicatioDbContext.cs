using IWANTAPP.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace IWANTAPP.Infra.Data
{
    public class ApplicatioDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicatioDbContext(DbContextOptions<ApplicatioDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .Property(p => p.Name).IsRequired();
            builder.Entity<Product>()
                .Property(p => p.Description).HasMaxLength(255);

            builder.Entity<Category>()
                .Property(c => c.Name).IsRequired();
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
        {
            configuration.Properties<string>()
                .HaveMaxLength(100);
        }


    }
}
