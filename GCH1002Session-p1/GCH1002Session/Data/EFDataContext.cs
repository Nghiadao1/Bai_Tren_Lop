using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GCH1002Session.Models;


namespace GCH1002Session.Data
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
