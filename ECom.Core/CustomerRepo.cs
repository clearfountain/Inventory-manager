using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using ECom.Data;
using ECore.Models;

namespace ECom.Core
{
    public class CustomerRepo : ICustomerRepo
    {
        public void DisplayCustomersGroupedByCity()
        {
            var _ctx = new EComContext();

            var CityAndItsCustomers = from c in _ctx.Customers
                                        .Include(c => c.Address)
                                        .ToList()
                                        group c by c.Address.City into g
                                        select g;
                       

            foreach(var city in CityAndItsCustomers)
            {
                Console.WriteLine("Customers in the city : {0}\n \n",city.Key);
                
                foreach(var cstmer in city)
                {
                    Console.WriteLine(cstmer.FirstName + " " + cstmer.LastName);
                }
                Console.WriteLine("\n \n");
            }
        }
    }

}
