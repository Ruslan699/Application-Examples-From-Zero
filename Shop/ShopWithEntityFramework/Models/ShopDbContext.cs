using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWithEntityFramework.Models
{
    class ShopDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }


    }
}
