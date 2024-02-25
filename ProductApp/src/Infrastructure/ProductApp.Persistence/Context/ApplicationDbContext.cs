using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;

namespace ProductApp.Persistence.Context;

public class ApplicationDbContext : DbContext
{
  public DbSet<Product> Products { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Product>().HasData
    (
      new Product
      {
        Id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 75
      },
      new Product
      {
        Id = Guid.NewGuid(), Name = "Paper", Value = 2, Quantity = 250
      },
      new Product
      {
        Id = Guid.NewGuid(), Name = "Book", Value = 25, Quantity = 17
      }
    );
  }
}