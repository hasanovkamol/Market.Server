using Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class MarketContext: IdentityDbContext
    {
        public MarketContext(DbContextOptions<MarketContext> option) : base(option)
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Deliver> delivers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetails> details { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Position> positions { get; set; }

    }
}
