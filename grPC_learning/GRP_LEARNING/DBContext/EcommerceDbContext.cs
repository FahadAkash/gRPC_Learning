using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRP_LEARNING.model;
using Microsoft.EntityFrameworkCore;

namespace GRP_LEARNING.DBContext
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options) {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            modelBuilder.Entity<Order>()
            .HasOne(o => o.product)
            .WithMany()
            .HasForeignKey( f => f.ProductId);
        }
    }
}