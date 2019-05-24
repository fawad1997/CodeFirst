using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CodeFirst.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConString")
        {
        }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}