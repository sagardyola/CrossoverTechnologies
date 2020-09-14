using CrossoverTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrossoverTechnologies.DAL
{
    public class CrossoverDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}