using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ECore.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public DateTime Time { get; set; }
        //[Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        //public int ShipperId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
