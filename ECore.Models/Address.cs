using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ECore.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
    }
}
