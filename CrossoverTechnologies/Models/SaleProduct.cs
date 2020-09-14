using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrossoverTechnologies.Models
{
    public class SaleProduct
    {
        [Key]
        [Column(Order = 1)]
        public int SaleID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductID { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Please enter Quantity.")]
        public int Quantity { get; set; }

        public virtual Sale Sale { get; set; }

        public virtual Product Product { get; set; }
    }
}