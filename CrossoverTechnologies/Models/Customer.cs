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

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}