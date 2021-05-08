using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.Linq;

using ECom.Data;

namespace ECom.Core
{
    public class OrderDetailRepo :  IOrderDetalRepo
    {
        public void DisplayTopFiveDeals()
        {
            var _ctx = new EComContext();

            var TopFiveDeals = (
                                    from o in _ctx.OrderDetails
                                   .Include(p => p.Product)
                                   .ToList()
                                    group o by o.Product.Name into g
                                    orderby g.Count() descending
                                    select  new {
                                        ProductName = g.Key,
                                        PurchaseCount = g.Count(),
                                        Amount = g.ToList()[0].Product.Price
                                       }
                                ).Take(5);

            Console.WriteLine("Top five deals are : \n \n");

            foreach(var Deal in TopFiveDeals)
            {
                Console.WriteLine("Product Name : "+ Deal.ProductName);
                Console.WriteLine("Product cost : " + Deal.Amount);
                Console.WriteLine("Number of times purchased : "+Deal.PurchaseCount);
                Console.WriteLine("\n \n");
            }

        }

        public void DisplayCustomersFromFiveLocationsWhoseOrdersIsGreaterThanAmount(decimal inputAmount)
        {
            var _ctx = new EComContext();

            decimal amount = inputAmount;

            var CustomersFromFiveLocationsWhoseOrdersIsGreaterThanAmount =

                    (
                    from o in _ctx.OrderDetails
                    .Include(p => p.Product)
                    .Include(c => c.Customer)
                    .Include(a => a.Customer.Address)
                    .ToList()
                    where o.Product.Price > amount
                    group o by o.Customer.Address into g
                    select g
                ).Distinct().Take(5);

            Console.WriteLine("Customers from 5 locations with orders greater than 50,000 \n \n");

            foreach (var address in CustomersFromFiveLocationsWhoseOrdersIsGreaterThanAmount)
            {
                Console.WriteLine("Customer : " + address.ToList()[0].Customer.FirstName + " " + address.ToList()[0].Customer.LastName);
                Console.WriteLine("Location : " + address.Key.StreetNumber + " " + address.Key.Street + " street, " + address.Key.City);
                Console.WriteLine("Amount : {0:#,###.##}",address.ToList()[0].Product.Price);
                Console.WriteLine("\n");
            }

            var a = 0;
        }

        public void DisplayAllSales()
        {
            var _ctx = new EComContext();

            var AllOrderDetails = from od in _ctx.OrderDetails
                                  .Include(p => p.Product)
                                        .ThenInclude(su => su.Supplier)
                                  .Include(o => o.Order)
                                  .Include(sh => sh.Shipper)
                                  .Include(c => c.Customer)
                                  .ToList()
                                  select od;

            int count = 0;
            decimal totalSalesAmount = 0;

            Console.WriteLine("ALL SALES : \n\n");
            foreach(var orderDetail in AllOrderDetails)
            {
                Console.WriteLine("S/N {0}", ++count);
                Console.WriteLine("Product name : {0}", orderDetail.Product.Name);
                Console.WriteLine("Customer name : {0} {1}", orderDetail.Customer.FirstName, orderDetail.Customer.LastName);
                Console.WriteLine("Quantity ordered : {0}", orderDetail.Quantity);
                Console.WriteLine("Unit price : {0:#,###}", orderDetail.Product.Price);
                Console.WriteLine("Total cost : {0:#,###}", (orderDetail.Product.Price * orderDetail.Quantity) );
                totalSalesAmount += (orderDetail.Product.Price * orderDetail.Product.Quantity);

                Console.WriteLine("\n");
            }

            //Console.WriteLine("\nTotal sales : {0:#,###}", totalSalesAmount);

        }

        public void DisplaySalesByCategory()
        {
            var _ctx = new EComContext();
            decimal totalSales = 0;

            var salesByCategory = from od in _ctx.OrderDetails
                                  .Include(cat => cat.Product.Category)
                                  .ToList()
                                  group od by od.Product.Category into g
                                  select g;

            Console.WriteLine("SALES BY CATEGORY : \n\n");

            foreach (var category in salesByCategory)
            {
                string catName = category.Key.Name;
                decimal catSale = 0;
                int catQuantity = 0;

                var catToList = category.ToList();

                foreach(var orderDet in catToList)
                {
                    catSale += ( orderDet.Product.Price * orderDet.Quantity );
                    catQuantity += orderDet.Quantity;
                }

                Console.WriteLine("Category name : {0}", catName);
                Console.WriteLine("Total quantity sold : {0}", catQuantity);
                Console.WriteLine("Total category sale : {0:#,###}", catSale);
                Console.WriteLine("\n");

                totalSales += catSale;
            }
            Console.WriteLine("Total sales : {0:#,###}", totalSales);
        }

        public void DisplaySalesByCity()
        {
            var _ctx = new EComContext();
            decimal totalSales = 0;

            var AllSalesGroupedByCity = from od in _ctx.OrderDetails
                                        .Include(p => p.Product)
                                        .Include(c => c.Customer)
                                            .ThenInclude(a => a.Address)
                                        .ToList()
                                        group od by od.Customer.Address.City into g
                                        select g;
            //var test = true;
            Console.WriteLine("SALES BY CITY : \n\n");

            foreach (var category in AllSalesGroupedByCity)
            {
                string cityName = category.Key;
                decimal citySale = 0;
                int cityQuantity = 0;

                var catToList = category.ToList();

                foreach (var orderDet in catToList)
                {
                    citySale += (orderDet.Product.Price * orderDet.Quantity);
                    cityQuantity += orderDet.Quantity;
                }

                Console.WriteLine("City name : {0}", cityName);
                Console.WriteLine("Total quantity sold in city : {0}", cityQuantity);
                Console.WriteLine("Total sale in city : {0:#,###}", citySale);
                Console.WriteLine("\n");

                totalSales += citySale;
            }
            Console.WriteLine("Total sales : {0:#,###}", totalSales);
        }

        public void DisplaySalesByProduct()
        {
            var _ctx = new EComContext();
            decimal totalSales = 0;


            var AllSalesGroupedByProduct = from od in _ctx.OrderDetails
                                           .Include(p => p.Product)
                                           .ToList()
                                           group od by od.Product into g
                                           select g;

            Console.WriteLine("SALES BY PRODUCT : \n\n");

            foreach (var product in AllSalesGroupedByProduct)
            {
                string productName = product.Key.Name;
                decimal productSale = 0;
                int productQuantity = 0;

                var catToList = product.ToList();

                foreach (var orderDet in catToList)
                {
                    productSale += (orderDet.Product.Price * orderDet.Quantity);
                    productQuantity += orderDet.Quantity;
                }

                Console.WriteLine("Product name : {0}", productName);
                Console.WriteLine("Total quantity of product sold : {0}", productQuantity);
                Console.WriteLine("Total sale of product : {0:#,###}", productSale);
                Console.WriteLine("\n");

                totalSales += productSale;
            }
            Console.WriteLine("Total sales : {0:#,###}", totalSales);

        }

        public void DisplaySalesByShipper()
        {
            var _ctx = new EComContext();
            decimal totalSales = 0;

            var AllSalesByShipper = from od in _ctx.OrderDetails
                                    .Include(sh => sh.Shipper)
                                    .Include(p => p.Product)
                                    .ToList()
                                    group od by od.Shipper into g
                                    select g;

            Console.WriteLine("SALES BY SHIPPER : \n\n");

            foreach (var shipper in AllSalesByShipper)
            {
                string shipperName = shipper.Key.ShipperName;
                decimal shipperSale = 0;
                int shipperQuantity = 0;

                var catToList = shipper.ToList();

                foreach (var orderDet in catToList)
                {
                    shipperSale += (orderDet.Product.Price * orderDet.Quantity);
                    shipperQuantity += orderDet.Quantity;
                }

                Console.WriteLine("Shipper name : {0}", shipperName);
                Console.WriteLine("Total product shipped by shipper to customers : {0}", shipperQuantity);
                Console.WriteLine("Total sale shipped by shipper : {0:#,###}", shipperSale);
                Console.WriteLine("\n");

                totalSales += shipperSale;
            }
            Console.WriteLine("Total sales : {0:#,###}", totalSales);

        }

        public void DisplaySalesBySupplier()
        {
            var _ctx = new EComContext();
            decimal totalSales = 0;

            var AllSalesBySupplier = from od in _ctx.OrderDetails
                                    .Include(p => p.Product)
                                        .ThenInclude(su => su.Supplier)
                                    .ToList()
                                    group od by od.Product.Supplier into g
                                    select g;

            Console.WriteLine("SALES BY SUPPLIER : \n\n");

            foreach (var supplier in AllSalesBySupplier)
            {
                string supplierName = supplier.Key.SupplierName;
                decimal supplierSale = 0;
                int supplierQuantity = 0;

                var catToList = supplier.ToList();

                foreach (var orderDet in catToList)
                {
                    supplierSale += (orderDet.Product.Price * orderDet.Quantity);
                    supplierQuantity += orderDet.Quantity;
                }

                Console.WriteLine("Supplier name : {0}", supplierName);
                Console.WriteLine("Total product sales supplied by supplier : {0}", supplierQuantity);
                Console.WriteLine("Total sale of product by supplier : {0:#,###}", supplierSale);
                Console.WriteLine("\n");

                totalSales += supplierSale;
            }
            Console.WriteLine("Total sales : {0:#,###}", totalSales);

        }

        public void DisplaySalesByCustomer()
        {
            var _ctx = new EComContext();
            decimal totalSales = 0;

            var AllSalesByCustomer = from od in _ctx.OrderDetails
                                    .Include(c => c.Customer)
                                    .Include(p => p.Product)
                                    .ToList()
                                     group od by od.Customer into g
                                     select g;

            Console.WriteLine("SALES BY CUSTOMER : \n\n");

            foreach (var customer in AllSalesByCustomer)
            {
                string customerName = customer.Key.FirstName + " " + customer.Key.LastName;
                decimal customerSale = 0;
                int customerQuantity = 0;

                var catToList = customer.ToList();

                foreach (var orderDet in catToList)
                {
                    customerSale += (orderDet.Product.Price * orderDet.Quantity);
                    customerQuantity += orderDet.Quantity;
                }

                Console.WriteLine("Customer name : {0}", customerName);
                Console.WriteLine("Total number of products bought by customer : {0}", customerQuantity);
                Console.WriteLine("Total cost of products bought by customer : {0:#,###}", customerSale);
                Console.WriteLine("\n");

                totalSales += customerSale;
            }
            Console.WriteLine("Total sales : {0:#,###}", totalSales);

        }



    }
}
