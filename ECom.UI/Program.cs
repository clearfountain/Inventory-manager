using System.Linq;
using System;

using Microsoft.EntityFrameworkCore;
using ECom.Core;
using ECom.Data;

namespace ECom.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SessionActive = true;
            bool ValidHomeOption = true;
            int HomeOption = 0;



            while (SessionActive == true)
            {
                Console.Clear();
                if(ValidHomeOption == false)
                {
                    Console.WriteLine("Invalid input, choose a valid input then press enter");
                }
                else
                {
                    Console.WriteLine("Choose an option then press enter : \n");
                }

                Console.WriteLine("1. Display customers grouped by city");
                Console.WriteLine("2. Display top 5 deals");
                Console.WriteLine("3. Display customers from 5 locations whose orders is greater than 50,000");
                Console.WriteLine("4. View sales reports");

                if (int.TryParse(Console.ReadLine(), out HomeOption)) 
                {
                    if ((HomeOption >= 1) && (HomeOption <= 4))
                    {
                        switch (HomeOption)
                        {
                            case 1:
                                DisplayCustomersByCity(new CustomerRepo());
                                AskUserToCOntinue();
                                break;
                            case 2:
                                DisplayTopFiveDeals(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 3:
                                DisplayCustomersFromFiveLocationsWhoseOrdersIsGreaterThanFiftyThousand(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 4:
                                LoadReportsView();
                                AskUserToCOntinue();
                                break;

                        }
                    }
                    else
                        ValidHomeOption = false;



                    Console.WriteLine("\n \n  ");
                }
                else
                {
                    ValidHomeOption = false;
                }


            }

        }

        public static void DisplayCustomersByCity(ICustomerRepo customerRepo)
        {
            Console.Clear();
            customerRepo.DisplayCustomersGroupedByCity();
        }

        public static void DisplayTopFiveDeals(IOrderDetalRepo orderDetalRepo)
        {
            Console.Clear();
            orderDetalRepo.DisplayTopFiveDeals();
        }

        public static void DisplayCustomersFromFiveLocationsWhoseOrdersIsGreaterThanFiftyThousand(IOrderDetalRepo orderDetalRepo)
        {
            Console.Clear();
            orderDetalRepo.DisplayCustomersFromFiveLocationsWhoseOrdersIsGreaterThanAmount(50_000);
        }

        public static void LoadReportsView()
        {
            bool stayInReportsView = true;
            bool ValidReportsViewSelection = true;
            int UserSelection = 0;

            while(stayInReportsView == true)
            {
                Console.Clear();

                if (!ValidReportsViewSelection)
                {
                    Console.WriteLine("Invalid input, choose an option then press enter : \n");
                }
                else
                {
                    Console.WriteLine("Choose and option then press enter : \n");
                }

                Console.WriteLine("1. View all sales");
                Console.WriteLine("2. View sales by category");
                Console.WriteLine("3. View sales by city");
                Console.WriteLine("4. View sales by product");
                Console.WriteLine("5. View sales by shipper");
                Console.WriteLine("6. View sales by supplier");
                Console.WriteLine("7. View sales by customer");

                if ( int.TryParse(Console.ReadLine(), out UserSelection))
                {
                    if( (UserSelection >= 1) && (UserSelection <= 7) )
                    {
                        switch (UserSelection)
                        {
                            case 1:
                                ViewAllSales(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 2:
                                ViewSalesByCategory(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 3:
                                ViewSalesByCity(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 4:
                                ViewSalesByProduct(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 5:
                                ViewSalesByShipper(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 6:
                                ViewSalesBySupplier(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                            case 7:
                                ViewSalesByCustomer(new OrderDetailRepo());
                                AskUserToCOntinue();
                                break;
                        }
                    }
                    else
                    {
                        ValidReportsViewSelection = true;
                    }
                }
                else
                {
                    ValidReportsViewSelection = false;
                }
            }
        }

        public static void ViewAllSales(IOrderDetalRepo OrderDetailRepo)
        {
            Console.Clear();
            OrderDetailRepo.DisplayAllSales();
        }

        public static void ViewSalesByCategory(IOrderDetalRepo OrderDetailRepo)
        {
            Console.Clear();
            OrderDetailRepo.DisplaySalesByCategory();
        }

        public static void ViewSalesByCity(IOrderDetalRepo OrderDetailRepo)
        {
            Console.Clear();
            OrderDetailRepo.DisplaySalesByCity();
        }

        public static void ViewSalesByProduct(IOrderDetalRepo OrderDetailRepo)
        {
            Console.Clear();
            OrderDetailRepo.DisplaySalesByProduct();
        }

        public static void ViewSalesByShipper(IOrderDetalRepo OrderDetailRepo)
        {
            Console.Clear();
            OrderDetailRepo.DisplaySalesByShipper();
        }

        public static void ViewSalesBySupplier(IOrderDetalRepo OrderDetailRepo)
        {
            Console.Clear();
            OrderDetailRepo.DisplaySalesBySupplier();
        }

        public static void ViewSalesByCustomer(IOrderDetalRepo OrderDetailRepo)
        {
            Console.Clear();
            OrderDetailRepo.DisplaySalesByCustomer();
        }


        public static void AskUserToCOntinue()
        {
            string userInput;

            bool validInput = false;

            while (validInput == false)
            {
                Console.WriteLine("Press b then enter to go back to home page");

                userInput = Console.ReadLine();

                if ((userInput == "B") || (userInput == "b"))
                {
                    validInput = true;
                }
            }

        }
    }
}
