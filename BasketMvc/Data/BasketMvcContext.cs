using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasketMvc.Models;

namespace BasketMvc.Data
{
    public class BasketMvcContext : DbContext
    {
        public BasketMvcContext (DbContextOptions<BasketMvcContext> options)
            : base(options)
        {
        }

        public DbSet<BasketMvc.Models.Product> Product { get; set; } = default!;
    }
}
