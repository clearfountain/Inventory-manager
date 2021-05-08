﻿// <auto-generated />
using System;
using ECom.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECom.Data.Migrations
{
    [DbContext(typeof(EComContext))]
    [Migration("20210507145654_Fix-CustomerId-Column-Values-In-OrderDetails-Table")]
    partial class FixCustomerIdColumnValuesInOrderDetailsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECore.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Lagos",
                            CustomerId = 1,
                            Street = "Adeniji Adele",
                            StreetNumber = "42A"
                        },
                        new
                        {
                            AddressId = 2,
                            City = "Port Harcourt",
                            CustomerId = 2,
                            Street = "Tombia",
                            StreetNumber = "30"
                        },
                        new
                        {
                            AddressId = 3,
                            City = "Abuja",
                            CustomerId = 3,
                            Street = "Oliver Tambo",
                            StreetNumber = "5"
                        },
                        new
                        {
                            AddressId = 4,
                            City = "Ibadan",
                            CustomerId = 4,
                            Street = "Ojo'badan",
                            StreetNumber = "26"
                        },
                        new
                        {
                            AddressId = 5,
                            City = "Uyo",
                            CustomerId = 5,
                            Street = "Emco",
                            StreetNumber = "15B"
                        },
                        new
                        {
                            AddressId = 6,
                            City = "Abuja",
                            CustomerId = 6,
                            Street = "Abbey",
                            StreetNumber = "120"
                        },
                        new
                        {
                            AddressId = 7,
                            City = "Lagos",
                            CustomerId = 7,
                            Street = "Bandara",
                            StreetNumber = "92"
                        },
                        new
                        {
                            AddressId = 8,
                            City = "Lagos",
                            CustomerId = 8,
                            Street = "Altgasse",
                            StreetNumber = "8"
                        },
                        new
                        {
                            AddressId = 9,
                            City = "Port Harcourt",
                            CustomerId = 9,
                            Street = "Osu",
                            StreetNumber = "21"
                        },
                        new
                        {
                            AddressId = 10,
                            City = "Uyo",
                            CustomerId = 10,
                            Street = "Hampton",
                            StreetNumber = "35"
                        },
                        new
                        {
                            AddressId = 11,
                            City = "Lagos",
                            CustomerId = 11,
                            Street = "Marina",
                            StreetNumber = "103"
                        },
                        new
                        {
                            AddressId = 12,
                            City = "Ibadan",
                            CustomerId = 12,
                            Street = "Marktgasse",
                            StreetNumber = "40C"
                        },
                        new
                        {
                            AddressId = 13,
                            City = "Lagos",
                            CustomerId = 13,
                            Street = "Havelska",
                            StreetNumber = "72"
                        },
                        new
                        {
                            AddressId = 14,
                            City = "Uyo",
                            CustomerId = 14,
                            Street = "F Line",
                            StreetNumber = "31"
                        });
                });

            modelBuilder.Entity("ECore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Phones & Tablets"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Home & Kitchen"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Fashion"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Automobile"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Health & Beauty"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Gaming"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Sporting Goods"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Computing"
                        },
                        new
                        {
                            CategoryId = 10,
                            Name = "Baby Products"
                        });
                });

            modelBuilder.Entity("ECore.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            CustomerId = 2,
                            FirstName = "Jane",
                            LastName = "Doe"
                        },
                        new
                        {
                            CustomerId = 3,
                            FirstName = "Chris",
                            LastName = "Imoni"
                        },
                        new
                        {
                            CustomerId = 4,
                            FirstName = "Lawrence",
                            LastName = "Nwachukwu"
                        },
                        new
                        {
                            CustomerId = 5,
                            FirstName = "Abubakar",
                            LastName = "Mohammed"
                        },
                        new
                        {
                            CustomerId = 6,
                            FirstName = "Esther",
                            LastName = "Adesokan"
                        },
                        new
                        {
                            CustomerId = 7,
                            FirstName = "Jadesola",
                            LastName = "Akande"
                        },
                        new
                        {
                            CustomerId = 8,
                            FirstName = "Emem",
                            LastName = "Nkamare"
                        },
                        new
                        {
                            CustomerId = 9,
                            FirstName = "Gloria",
                            LastName = "Lawal"
                        },
                        new
                        {
                            CustomerId = 10,
                            FirstName = "Toyin",
                            LastName = "Ogunjobi"
                        },
                        new
                        {
                            CustomerId = 11,
                            FirstName = "Bayo",
                            LastName = "Ogundele"
                        },
                        new
                        {
                            CustomerId = 12,
                            FirstName = "Nawok",
                            LastName = "Gotau"
                        },
                        new
                        {
                            CustomerId = 13,
                            FirstName = "Abiodun",
                            LastName = "Alonge"
                        },
                        new
                        {
                            CustomerId = 14,
                            FirstName = "Chinenye",
                            LastName = "Obiano"
                        });
                });

            modelBuilder.Entity("ECore.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 1,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 501, DateTimeKind.Local).AddTicks(1553)
                        },
                        new
                        {
                            OrderId = 2,
                            CustomerId = 2,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7244)
                        },
                        new
                        {
                            OrderId = 3,
                            CustomerId = 3,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7273)
                        },
                        new
                        {
                            OrderId = 4,
                            CustomerId = 4,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7275)
                        },
                        new
                        {
                            OrderId = 5,
                            CustomerId = 5,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7277)
                        },
                        new
                        {
                            OrderId = 6,
                            CustomerId = 6,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7278)
                        },
                        new
                        {
                            OrderId = 7,
                            CustomerId = 7,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7280)
                        },
                        new
                        {
                            OrderId = 8,
                            CustomerId = 8,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7282)
                        },
                        new
                        {
                            OrderId = 9,
                            CustomerId = 9,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7284)
                        },
                        new
                        {
                            OrderId = 10,
                            CustomerId = 10,
                            Time = new DateTime(2021, 5, 7, 15, 56, 53, 502, DateTimeKind.Local).AddTicks(7285)
                        });
                });

            modelBuilder.Entity("ECore.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShipperId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShipperId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderDetailId = 1,
                            CustomerId = 1,
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 2,
                            ShipperId = 5
                        },
                        new
                        {
                            OrderDetailId = 2,
                            CustomerId = 1,
                            OrderId = 1,
                            ProductId = 6,
                            Quantity = 3,
                            ShipperId = 3
                        },
                        new
                        {
                            OrderDetailId = 3,
                            CustomerId = 2,
                            OrderId = 2,
                            ProductId = 8,
                            Quantity = 1,
                            ShipperId = 1
                        },
                        new
                        {
                            OrderDetailId = 4,
                            CustomerId = 2,
                            OrderId = 2,
                            ProductId = 1,
                            Quantity = 4,
                            ShipperId = 4
                        },
                        new
                        {
                            OrderDetailId = 5,
                            CustomerId = 10,
                            OrderId = 10,
                            ProductId = 5,
                            Quantity = 7,
                            ShipperId = 2
                        },
                        new
                        {
                            OrderDetailId = 6,
                            CustomerId = 10,
                            OrderId = 10,
                            ProductId = 7,
                            Quantity = 3,
                            ShipperId = 2
                        },
                        new
                        {
                            OrderDetailId = 7,
                            CustomerId = 3,
                            OrderId = 3,
                            ProductId = 8,
                            Quantity = 6,
                            ShipperId = 3
                        },
                        new
                        {
                            OrderDetailId = 8,
                            CustomerId = 3,
                            OrderId = 3,
                            ProductId = 3,
                            Quantity = 8,
                            ShipperId = 1
                        },
                        new
                        {
                            OrderDetailId = 9,
                            CustomerId = 3,
                            OrderId = 3,
                            ProductId = 9,
                            Quantity = 3,
                            ShipperId = 3
                        },
                        new
                        {
                            OrderDetailId = 10,
                            CustomerId = 8,
                            OrderId = 4,
                            ProductId = 2,
                            Quantity = 7,
                            ShipperId = 2
                        },
                        new
                        {
                            OrderDetailId = 11,
                            CustomerId = 6,
                            OrderId = 8,
                            ProductId = 6,
                            Quantity = 11,
                            ShipperId = 4
                        },
                        new
                        {
                            OrderDetailId = 12,
                            CustomerId = 10,
                            OrderId = 6,
                            ProductId = 1,
                            Quantity = 13,
                            ShipperId = 1
                        },
                        new
                        {
                            OrderDetailId = 13,
                            CustomerId = 6,
                            OrderId = 8,
                            ProductId = 2,
                            Quantity = 5,
                            ShipperId = 3
                        },
                        new
                        {
                            OrderDetailId = 14,
                            CustomerId = 5,
                            OrderId = 9,
                            ProductId = 10,
                            Quantity = 6,
                            ShipperId = 4
                        },
                        new
                        {
                            OrderDetailId = 15,
                            CustomerId = 7,
                            OrderId = 3,
                            ProductId = 7,
                            Quantity = 5,
                            ShipperId = 2
                        },
                        new
                        {
                            OrderDetailId = 16,
                            CustomerId = 9,
                            OrderId = 5,
                            ProductId = 3,
                            Quantity = 1,
                            ShipperId = 3
                        });
                });

            modelBuilder.Entity("ECore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ShipperId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ShipperId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3,
                            Description = "3+1 gas cooker with metal finish",
                            Name = "Scanfrost Gas Cooker",
                            Price = 70000.00m,
                            Quantity = 5,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "LED Tv with inbuilt satellite",
                            Name = "32\" Samsung TV",
                            Price = 55000.00m,
                            Quantity = 10,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "4 speaker + 1 sub woofer home theatre",
                            Name = "LG Home Theatre",
                            Price = 85000.00m,
                            Quantity = 2,
                            SupplierId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 3,
                            Description = "60 x 60 black inbuilt dishwasher",
                            Name = "Kitchencraft inbuilt dishwasher",
                            Price = 100000.00m,
                            Quantity = 8,
                            SupplierId = 4
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 9,
                            Description = "Laptop with bag and charger",
                            Name = "HP Stream Laptop",
                            Price = 170000.00m,
                            Quantity = 15,
                            SupplierId = 5
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 7,
                            Description = "Uncharted 4 PS4 CD",
                            Name = "Uncharted 4",
                            Price = 9000.00m,
                            Quantity = 30,
                            SupplierId = 6
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 4,
                            Description = "Size 8 black color crop top",
                            Name = "Zara crop top",
                            Price = 5000.00m,
                            Quantity = 7,
                            SupplierId = 7
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 10,
                            Description = "Super absorbent baby diaper",
                            Name = "Huggies Diapers for 1 year olds",
                            Price = 8000.00m,
                            Quantity = 31,
                            SupplierId = 8
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 8,
                            Description = "Black color, soft ground football boots",
                            Name = "Adidas ace football boots",
                            Price = 14000.00m,
                            Quantity = 13,
                            SupplierId = 9
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 6,
                            Description = "Black color waterproof eye liner",
                            Name = "MAC eyeliner",
                            Price = 5000.00m,
                            Quantity = 20,
                            SupplierId = 10
                        });
                });

            modelBuilder.Entity("ECore.Models.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShipperName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");

                    b.HasData(
                        new
                        {
                            ShipperId = 1,
                            ShipperName = "MAERSK"
                        },
                        new
                        {
                            ShipperId = 2,
                            ShipperName = "COSCO"
                        },
                        new
                        {
                            ShipperId = 3,
                            ShipperName = "DHL"
                        },
                        new
                        {
                            ShipperId = 4,
                            ShipperName = "FEDEX"
                        },
                        new
                        {
                            ShipperId = 5,
                            ShipperName = "HERMES"
                        });
                });

            modelBuilder.Entity("ECore.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            SupplierName = "Far East Mercantile"
                        },
                        new
                        {
                            SupplierId = 2,
                            SupplierName = "SIMS Nigeria"
                        },
                        new
                        {
                            SupplierId = 3,
                            SupplierName = "LG"
                        },
                        new
                        {
                            SupplierId = 4,
                            SupplierName = "Kitchencraft"
                        },
                        new
                        {
                            SupplierId = 5,
                            SupplierName = "HP"
                        },
                        new
                        {
                            SupplierId = 6,
                            SupplierName = "Playstation"
                        },
                        new
                        {
                            SupplierId = 7,
                            SupplierName = "Zara"
                        },
                        new
                        {
                            SupplierId = 8,
                            SupplierName = "Huggies"
                        },
                        new
                        {
                            SupplierId = 9,
                            SupplierName = "Adidas"
                        },
                        new
                        {
                            SupplierId = 10,
                            SupplierName = "MAC Cosmetics"
                        });
                });

            modelBuilder.Entity("ECore.Models.Address", b =>
                {
                    b.HasOne("ECore.Models.Customer", null)
                        .WithOne("Address")
                        .HasForeignKey("ECore.Models.Address", "CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ECore.Models.Order", b =>
                {
                    b.HasOne("ECore.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ECore.Models.OrderDetail", b =>
                {
                    b.HasOne("ECore.Models.Customer", "Customer")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ECore.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ECore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ECore.Models.Shipper", "Shipper")
                        .WithMany()
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("ECore.Models.Product", b =>
                {
                    b.HasOne("ECore.Models.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ECore.Models.Shipper", null)
                        .WithMany("Products")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("ECore.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("ECore.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ECore.Models.Customer", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("OrderDetails");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ECore.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("ECore.Models.Shipper", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ECore.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
