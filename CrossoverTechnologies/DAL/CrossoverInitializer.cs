using CrossoverTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossoverTechnologies.DAL
{
    public class CrossoverInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CrossoverDbContext>
    {
        protected override void Seed(CrossoverDbContext context)
        {
            var customerObj = new List<Customer>
            {
                new Customer{ Name = "Admin", Email="admin@mail.com"},
                new Customer{ Name = "User", Email="user@mail.com"}
            };
            customerObj.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}