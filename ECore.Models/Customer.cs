using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ECore.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }  
        public List<OrderDetail> OrderDetails { get; set; }
    }
}


