using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrossoverTechnologies.Models
{
    public class Sale
    {
        private DateTime _date = DateTime.Now;

        [Key]
        public int SaleID { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        [Display(Name = "Net Total")]
        public float NetTotal { get; set; }

        [Display(Name = "Gross Total")]
        public float GrossTotal { get; set; }

        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<SaleProduct> SaleProducts { get; set; }
    }
}