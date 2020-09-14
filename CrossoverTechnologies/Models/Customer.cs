using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossoverTechnologies.Models
{
    public class Customer
    {
        [Key]
        public int CID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}