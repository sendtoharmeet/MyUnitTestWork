using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class OrderDetail
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is Required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip is Required")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Phone is Required")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter phone Number")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "CardNumber is Required")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Card Number")]
        public int CardNumber { get; set; }

        [Required(ErrorMessage = "CardExpiryMonth is Required")]
        [Range(1, 12, ErrorMessage = "Please enter valid card expiry Month")]
        public int CardExpiryMonth { get; set; }
        
        [Required(ErrorMessage = "CardExpiryYear is Required")]
        [Range(1990, 2025, ErrorMessage = "Please enter valid card expiry Year")]
        public int CardExpiryYear { get; set; }

        [Required(ErrorMessage = "CardSecurityNumber is Required")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid card security Number")]
        public int CardSecurityCode { get; set; }

        [Required(ErrorMessage = "Product Id required")]
        [Range(0, int.MaxValue, ErrorMessage = "Please valid product id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Price Id required")]
        [Range(0.0, float.MaxValue, ErrorMessage = "Please valid price")]
        public decimal ProductPrice { get; set; }
        
    }
}
