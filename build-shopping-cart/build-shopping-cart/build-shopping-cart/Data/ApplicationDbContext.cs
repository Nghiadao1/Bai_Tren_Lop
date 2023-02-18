using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using build_shopping_cart.Models;
namespace build_shopping_cart.Data
{
    public class EFDataContext : IdentityDbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}