using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Ecommerce.Models;


namespace Ecommerce.Infra
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) {}

        public DbSet<Product> Product { get; set;}

    }
}