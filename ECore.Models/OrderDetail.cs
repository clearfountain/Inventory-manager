using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace ECore.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        //[Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }
    }
}
