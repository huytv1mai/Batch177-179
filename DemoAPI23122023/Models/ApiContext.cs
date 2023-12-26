using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DemoAPI23122023.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Product> Products { get; set; }
    }

}
