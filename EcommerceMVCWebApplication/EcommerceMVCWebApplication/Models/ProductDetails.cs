using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceMVCWebApplication.Models
{
    public class ProductDetails
    {
        [Key]
        public string Id { get; set; }
        [Required]   //not null
        [Display(Name = "ProductName")]
        [StringLength(50)]
        public string Name { get; set; }
        public string Category { get; set; }
        [Display(Name = "OrderDate")]
        public DateTime RegistrationDate { get; set; }
        [Display(Name = "ProductQuantity")]
        public int ProductQty { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [RegularExpression(@"\d{3,9}")]
        public string Password { get; set; }

    }
}