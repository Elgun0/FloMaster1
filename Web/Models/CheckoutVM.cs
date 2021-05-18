using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class CheckoutVM
    {
        public string CustomerID { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Customer Email")]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public List<Product> Products { get; set; }
        public List<int> ProductIds { get; set; }
        public AppUser AppUser { get; set; }
    }
}
