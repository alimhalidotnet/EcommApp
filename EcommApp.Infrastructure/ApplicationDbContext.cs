using EcommApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommApp.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // This property represents your database table
        public DbSet<Product> Products { get; set; }

    }

}
