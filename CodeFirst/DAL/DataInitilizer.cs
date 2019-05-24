using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.DAL
{
    public class DataInitilizer : DropCreateDatabaseIfModelChanges<MyContext>
    {
        public DataInitilizer()
        {
            this.Seed(new MyContext());
        }

        protected override void Seed(MyContext context)
        {
            base.Seed(context);
            Customer customer = new Customer()
            {
                Name = "Fawad",
                Address = "My address",
                Contact = "090078601",
                Orders = new List<Order>()
                {
                    new Order (){ OrderDate = "12/11/2022"}
                }
            };
        }
    }
}