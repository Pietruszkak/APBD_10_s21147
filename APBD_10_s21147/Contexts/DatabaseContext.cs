using APBD_10_s21147.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_10_s21147.Contexts;

public class DatabaseContext : DbContext
{
    public DbSet<Role> Roles { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<ProductCategory> ProductsCategories { get; set; }
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Role>().HasData(new List<Role>
        {
            new Role()
            {
                RoleId = 1,
                Name = "role1"
            }
        });
        modelBuilder.Entity<Account>().HasData(new List<Account>
        {
            new Account()
            {
                AccountId = 1,
                FirstName = "Account1",
                LastName = "ln1",
                Email = "e1",
                Phone = "ph1",
                RoleId = 1
            }
        });
        modelBuilder.Entity<Product>().HasData(new List<Product>
        {
            new Product()
            {
                ProductId = 1,
                Name = "Product1",
                Depth = 2.2m,
                Height = 2.2m,
                Weight = 2.2m,
                Width = 2.2m
            }
        });
        modelBuilder.Entity<Category>().HasData(new List<Category>
        {
            new Category()
            {
                CategoryId = 1,
                Name = "Category1",
            }
        });
        modelBuilder.Entity<ShoppingCart>().HasData(new List<ShoppingCart>
        {
            new ShoppingCart()
            {
                AccountId = 1,
                ProductId = 1,
                Amount = 12
            }
        });
        modelBuilder.Entity<ProductCategory>().HasData(new List<ProductCategory>
        {
            new ProductCategory()
            {
                ProductId = 1,
                CategoryId = 1
            }
        });
        
    }
}