using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossoverTechnologies.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Please enter a product name.")]
        public string Name { get; set; }

        [Display(Name = "SKU")]
        [Required(ErrorMessage = "Please enter SKU.")]
        public string SKU { get; set; }

        [Display(Name = "Price")]
        public float Price { get; set; }

        [Display(Name = "Cost Price")]
        public float CostPrice { get; set; }

        [Display(Name = "VAT")]
        public float VAT { get; set; }

        [Display(Name = "Stock Level")]
        [Required(ErrorMessage = "Please enter Stock level")]
        public int StockLevel { get; set; }

        public virtual ICollection<SaleProduct> SaleProducts { get; set; }
    }
}