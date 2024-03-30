using ETradeAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeAPI.Persistence.Contexts
{
    public class ETradeAPIDbContext : DbContext
    {
        public ETradeAPIDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }//Product entitysine qarsiliq olaraq Orders cedveli duzeltsin, modeli de entity den alsin
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
