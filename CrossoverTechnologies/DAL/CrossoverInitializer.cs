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
                new Customer{ Name = "Sagar Dyola", Email="sagardyola@gmail.com" },
                new Customer{ Name = "Sunita Ghale", Email="sunitaghale55@gmail.com" },
                new Customer{ Name = "David", Email="david@gmail.com" },
                new Customer{ Name = "John", Email="john@gmail.com" },
                new Customer{ Name = "Chris", Email="chris@gmail.com" },
                new Customer{ Name = "Bryan", Email="bryan@gmail.com" },
                new Customer{ Name = "Binita", Email="binita@gmail.com" },
                new Customer{ Name = "Amita", Email="amita@gmail.com" },
                new Customer{ Name = "Lisa", Email="lisa@gmail.com" }
            };
            customerObj.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var productObj = new List<Product>
            {
                new Product{ Name = "Samsung Tablet", SKU= "SAM-TAB-002", Price = 72.5F, CostPrice = 50.5F, VAT = 20, StockLevel = 5 },
                new Product{ Name = "Sony Tablet", SKU= "SONY-TAB-001", Price = 172.5F, CostPrice = 150.5F, VAT = 20, StockLevel = 15 },
                new Product{ Name = "iPad", SKU= "IPAD-001", Price = 472.5F, CostPrice = 350.5F, VAT = 20, StockLevel = 5 },
                new Product{ Name = "Samsung Galaxy s10", SKU= "GAL-001", Price = 372.5F, CostPrice = 300.5F, VAT = 20, StockLevel = 10 },
                new Product{ Name = "iWatch", SKU= "IW-001", Price = 272.5F, CostPrice = 200.5F, VAT = 20, StockLevel = 8 },
                new Product{ Name = "Acer Laptop", SKU= "ACER-001", Price = 872.5F, CostPrice = 600.5F, VAT = 20, StockLevel = 7 },
                new Product{ Name = "HP LCD Screen", SKU= "HP-001", Price = 202.5F, CostPrice = 150.5F, VAT = 20, StockLevel = 9 },
                new Product{ Name = "Wireless Mouse", SKU= "WIRELESS-001", Price = 50, CostPrice = 30.5F, VAT = 20, StockLevel = 20 },
                new Product{ Name = "Halogen Heater", SKU= "HEAT-001", Price = 182.5F, CostPrice = 100.1F, VAT = 20, StockLevel = 18 },
                new Product{ Name = "Fan", SKU= "FAN-001", Price = 82.5F, CostPrice = 30.5F, VAT = 20, StockLevel = 11 }
            };
            productObj.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}