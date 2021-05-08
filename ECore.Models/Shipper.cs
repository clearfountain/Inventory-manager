using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ECore.Models
{
    public class Shipper
    {
        [Key]
        public int ShipperId { get; set; }
        [Required]
        public string ShipperName { get; set; }
        public List<Product> Products { get; set; }
    }
}
