using System;
using System.Collections.Generic;
using System.Text;

namespace ECom.Core
{
    public interface IOrderDetalRepo
    {
        public void DisplayTopFiveDeals();

        public void DisplayCustomersFromFiveLocationsWhoseOrdersIsGreaterThanAmount(decimal inputAmount);

        public void DisplayAllSales();

        public void DisplaySalesByCategory();

        public void DisplaySalesByCity();

        public void DisplaySalesByProduct();

        public void DisplaySalesByShipper();

        public void DisplaySalesBySupplier();

        public void DisplaySalesByCustomer();


    }
}
