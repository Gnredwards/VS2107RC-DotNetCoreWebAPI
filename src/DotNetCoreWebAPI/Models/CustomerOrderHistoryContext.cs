using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Models
{
    public class CustomerOrderHistoryContext : DbContext, ICustomerOrderHistoryContext
    {
     
        public CustomerOrderHistoryContext(DbContextOptions<CustomerOrderHistoryContext> options)
        : base(options)
        { }

        public DbSet<CustomerOrderHistory> GetCustomerOrderHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerOrderHistory>().HasKey(t => new { t.ProductName });
        }

    }
}
