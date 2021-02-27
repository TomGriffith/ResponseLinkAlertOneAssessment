using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResponseLinkAlertOneAssessment.Models;

namespace ResponseLinkAlertOneAssessment.Data
{
    /// <summary>
    /// Provides access to the database
    /// </summary>
    public class StoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ShippingOption> ShippingOptions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=STORE;Integrated Security=true;");
        }
    }
}
