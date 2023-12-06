using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
//using Products.Models;

namespace Products.Data
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=ADMINPC;Database=BikeStores;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        //public DbSet<Product> Products {get; set; }
    }
}
DbContext.on