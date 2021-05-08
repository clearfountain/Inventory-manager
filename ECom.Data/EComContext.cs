using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using ECore.Models;

namespace ECom.Data
{
    public class EComContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-R0IBRK5V;" +
                    "Initial Catalog=Week6EFCoreTask;"+
                    "Integrated Security=True;"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            /*modelBuilder.Entity<Customer>()
                .HasOne(a => a.Address)
                .WithOne(b => b.Customer)
                .HasForeignKey<Address>(b => b.CustomerId);*/

            modelBuilder.Entity<Customer>()
             .HasData(
                  new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe" },
                  new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Doe" },
                  new Customer { CustomerId = 3, FirstName = "Chris", LastName = "Imoni" },
                  new Customer { CustomerId = 4, FirstName = "Lawrence", LastName = "Nwachukwu" },
                  new Customer { CustomerId = 5, FirstName = "Abubakar", LastName = "Mohammed" },
                  new Customer { CustomerId = 6, FirstName = "Esther", LastName = "Adesokan" },
                  new Customer { CustomerId = 7, FirstName = "Jadesola", LastName = "Akande" },
                  new Customer { CustomerId = 8, FirstName = "Emem", LastName = "Nkamare" },
                  new Customer { CustomerId = 9, FirstName = "Gloria", LastName = "Lawal" },
                  new Customer { CustomerId = 10, FirstName = "Toyin", LastName = "Ogunjobi" },
                  new Customer { CustomerId = 11, FirstName = "Bayo", LastName = "Ogundele" },
                  new Customer { CustomerId = 12, FirstName = "Nawok", LastName = "Gotau" },
                  new Customer { CustomerId = 13, FirstName = "Abiodun", LastName = "Alonge" },
                  new Customer { CustomerId = 14, FirstName = "Chinenye", LastName = "Obiano" }
              );

            modelBuilder.Entity<Address>()
               .HasData(
                    new Address { AddressId = 1, StreetNumber = "42A", Street = "Adeniji Adele", City = "Lagos", CustomerId = 1 },
                    new Address { AddressId = 2, StreetNumber = "30", Street = "Tombia", City = "Port Harcourt", CustomerId = 2 },
                    new Address { AddressId = 3, StreetNumber = "5", Street = "Oliver Tambo", City = "Abuja", CustomerId = 3 },
                    new Address { AddressId = 4, StreetNumber = "26", Street = "Ojo'badan", City = "Ibadan", CustomerId = 4 },
                    new Address { AddressId = 5, StreetNumber = "15B", Street = "Emco", City = "Uyo", CustomerId = 5 },
                    new Address { AddressId = 6, StreetNumber = "120", Street = "Abbey", City = "Abuja", CustomerId = 6 },
                    new Address { AddressId = 7, StreetNumber = "92", Street = "Bandara", City = "Lagos", CustomerId = 7 },
                    new Address { AddressId = 8, StreetNumber = "8", Street = "Altgasse", City = "Lagos", CustomerId = 8 },
                    new Address { AddressId = 9, StreetNumber = "21", Street = "Osu", City = "Port Harcourt", CustomerId = 9 },
                    new Address { AddressId = 10, StreetNumber = "35", Street = "Hampton", City = "Uyo", CustomerId = 10 },
                    new Address { AddressId = 11, StreetNumber = "103", Street = "Marina", City = "Lagos", CustomerId = 11 },
                    new Address { AddressId = 12, StreetNumber = "40C", Street = "Marktgasse", City = "Ibadan", CustomerId = 12 },
                    new Address { AddressId = 13, StreetNumber = "72", Street = "Havelska", City = "Lagos", CustomerId = 13 },
                   new Address { AddressId = 14, StreetNumber = "31", Street = "F Line", City = "Uyo", CustomerId = 14 }
            );

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { CategoryId = 1, Name = "Electronics" },
                    new Category { CategoryId = 2, Name = "Phones & Tablets" },
                    new Category { CategoryId = 3, Name = "Home & Kitchen" },
                    new Category { CategoryId = 4, Name = "Fashion" },
                    new Category { CategoryId = 5, Name = "Automobile" },
                    new Category { CategoryId = 6, Name = "Health & Beauty" },
                    new Category { CategoryId = 7, Name = "Gaming" },
                    new Category { CategoryId = 8, Name = "Sporting Goods" },
                    new Category { CategoryId = 9, Name = "Computing" },
                    new Category { CategoryId = 10, Name = "Baby Products" }
                );

            modelBuilder.Entity<Supplier>()
                .HasData(
                    new Supplier { SupplierId = 1, SupplierName = "Far East Mercantile" },
                    new Supplier { SupplierId = 2, SupplierName = "SIMS Nigeria" },
                    new Supplier { SupplierId = 3, SupplierName = "LG" },
                    new Supplier { SupplierId = 4, SupplierName = "Kitchencraft" },
                    new Supplier { SupplierId = 5, SupplierName = "HP" },
                    new Supplier { SupplierId = 6, SupplierName = "Playstation" },
                    new Supplier { SupplierId = 7, SupplierName = "Zara" },
                    new Supplier { SupplierId = 8, SupplierName = "Huggies" },
                    new Supplier { SupplierId = 9, SupplierName = "Adidas" },
                    new Supplier { SupplierId = 10, SupplierName = "MAC Cosmetics" }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product { ProductId = 1, SupplierId = 1, CategoryId = 3, Name = "Scanfrost Gas Cooker", Description = "3+1 gas cooker with metal finish", Price = 70_000.00M, Quantity = 5 },
                    new Product { ProductId = 2, SupplierId = 2, CategoryId = 1, Name = "32\" Samsung TV", Description = "LED Tv with inbuilt satellite", Price = 55_000.00M, Quantity = 10 },
                    new Product { ProductId = 3, SupplierId = 3, CategoryId = 1, Name = "LG Home Theatre", Description = "4 speaker + 1 sub woofer home theatre", Price = 85_000.00M, Quantity = 2 },
                    new Product { ProductId = 4, SupplierId = 4, CategoryId = 3, Name = "Kitchencraft inbuilt dishwasher", Description = "60 x 60 black inbuilt dishwasher", Price = 100_000.00M, Quantity = 8 },
                    new Product { ProductId = 5, SupplierId = 5, CategoryId = 9, Name = "HP Stream Laptop", Description = "Laptop with bag and charger", Price = 170_000.00M, Quantity = 15 },
                    new Product { ProductId = 6, SupplierId = 6, CategoryId = 7, Name = "Uncharted 4", Description = "Uncharted 4 PS4 CD", Price = 9_000.00M, Quantity = 30 },
                    new Product { ProductId = 7, SupplierId = 7, CategoryId = 4, Name = "Zara crop top", Description = "Size 8 black color crop top", Price = 5_000.00M, Quantity = 7 },
                    new Product { ProductId = 8, SupplierId = 8, CategoryId = 10, Name = "Huggies Diapers for 1 year olds", Description = "Super absorbent baby diaper", Price = 8_000.00M, Quantity = 31 },
                    new Product { ProductId = 9, SupplierId = 9, CategoryId = 8, Name = "Adidas ace football boots", Description = "Black color, soft ground football boots", Price = 14_000.00M, Quantity = 13 },
                    new Product { ProductId = 10, SupplierId = 10, CategoryId = 6, Name = "MAC eyeliner", Description = "Black color waterproof eye liner", Price = 5_000.00M, Quantity = 20 }
                 );

            modelBuilder.Entity<Shipper>()
                .HasData(
                    new Shipper { ShipperId = 1, ShipperName = "MAERSK" },
                    new Shipper { ShipperId = 2, ShipperName = "COSCO" },
                    new Shipper { ShipperId = 3, ShipperName = "DHL" },
                    new Shipper { ShipperId = 4, ShipperName = "FEDEX" },
                    new Shipper { ShipperId = 5, ShipperName = "HERMES" }
                );

            modelBuilder.Entity<Order>()
                .HasData(
                    new Order { OrderId = 1, CustomerId = 1, Time = DateTime.Now },
                    new Order { OrderId = 2, CustomerId = 2, Time = DateTime.Now },
                    new Order { OrderId = 3, CustomerId = 3, Time = DateTime.Now },
                    new Order { OrderId = 4, CustomerId = 4, Time = DateTime.Now },
                    new Order { OrderId = 5, CustomerId = 5, Time = DateTime.Now },
                    new Order { OrderId = 6, CustomerId = 6, Time = DateTime.Now },
                    new Order { OrderId = 7, CustomerId = 7, Time = DateTime.Now },
                    new Order { OrderId = 8, CustomerId = 8, Time = DateTime.Now },
                    new Order { OrderId = 9, CustomerId = 9, Time = DateTime.Now },
                    new Order { OrderId = 10, CustomerId = 10, Time = DateTime.Now }
                    /*new Order { OrderId = 11, CustomerId = 11, Time = DateTime.Now },
                    new Order { OrderId = 12, CustomerId = 12, Time = DateTime.Now },
                    new Order { OrderId = 13, CustomerId = 13, Time = DateTime.Now },
                    new Order { OrderId = 14, CustomerId = 14, Time = DateTime.Now }*/
                );

            modelBuilder.Entity<OrderDetail>()
                    .HasData(
                        new OrderDetail { OrderDetailId = 1, ProductId = 1, CustomerId = 1, OrderId = 1, ShipperId = 5, Quantity = 2},
                        new OrderDetail { OrderDetailId = 2, ProductId = 6, CustomerId = 1, OrderId = 1, ShipperId = 3, Quantity = 3},
                        new OrderDetail { OrderDetailId = 3, ProductId = 8, CustomerId = 2, OrderId = 2, ShipperId = 1, Quantity = 1},
                        new OrderDetail { OrderDetailId = 4, ProductId = 1, CustomerId = 2, OrderId = 2, ShipperId = 4, Quantity = 4},
                        new OrderDetail { OrderDetailId = 5, ProductId = 5, CustomerId = 10, OrderId = 10, ShipperId = 2, Quantity = 7},
                        new OrderDetail { OrderDetailId = 6, ProductId = 7, CustomerId = 10, OrderId = 10, ShipperId = 2, Quantity = 3},
                        new OrderDetail { OrderDetailId = 7, ProductId = 8, CustomerId = 3, OrderId = 3, ShipperId = 3, Quantity = 6},
                        new OrderDetail { OrderDetailId = 8, ProductId = 3, CustomerId = 3, OrderId = 3, ShipperId = 1, Quantity = 8},
                        new OrderDetail { OrderDetailId = 9, ProductId = 9, CustomerId = 3, OrderId = 3, ShipperId = 3, Quantity = 3},
                        new OrderDetail { OrderDetailId = 10, ProductId = 2, CustomerId = 8, OrderId = 4, ShipperId = 2, Quantity = 7},
                        new OrderDetail { OrderDetailId = 11, ProductId = 6, CustomerId = 6, OrderId = 8, ShipperId = 4, Quantity = 11},
                        new OrderDetail { OrderDetailId = 12, ProductId = 1, CustomerId = 10, OrderId = 6, ShipperId = 1, Quantity = 13},
                        new OrderDetail { OrderDetailId = 13, ProductId = 2, CustomerId = 6, OrderId = 8, ShipperId = 3, Quantity = 5},
                        new OrderDetail { OrderDetailId = 14, ProductId = 10, CustomerId = 5, OrderId = 9, ShipperId = 4, Quantity = 6},
                        new OrderDetail { OrderDetailId = 15, ProductId = 7, CustomerId = 7, OrderId = 3, ShipperId = 2, Quantity = 5},
                        new OrderDetail { OrderDetailId = 16, ProductId = 3, CustomerId = 9, OrderId = 5, ShipperId = 3, Quantity = 1}
                    );
        }
    }
}
