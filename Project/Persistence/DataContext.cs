using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : IdentityDbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ProductCatalogType> ProductCatalogTypes { get; set; } // Corrected the property name

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the ProductCatalogType entity
        modelBuilder.Entity<ProductCatalogType>(entity =>
        {
            entity.HasMany(e => e.ProductCatalog)
            .WithOne(e => e.CatalogType)
            .HasForeignKey(e => e.CatalogTypeId);
        });

        modelBuilder.Entity<Account>().HasOne(a => a.Institution)
        .WithOne(i => i.Account)
        .HasForeignKey<Institution>(i => i.DefaultAccountId);
    }
}
