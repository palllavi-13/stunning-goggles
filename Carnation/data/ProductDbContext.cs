using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carnation.data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
           : base(options)
        {
        }

        public DbSet<Carnation.Models.Product> Products { get; set; }
    }
}
