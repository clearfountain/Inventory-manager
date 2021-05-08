using System;
using System.Collections.Generic;
using System.Text;

namespace ECore.Models
{
    public class CityCustomersDataDTO
    {
        public string CityName { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
