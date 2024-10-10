﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restuarent_Backend.Data;

#nullable disable

namespace Restuarent_Backend.Migrations
{
    [DbContext(typeof(ResturantDBContext))]
    [Migration("20241009062134_full-database")]
    partial class fulldatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restuarent_Backend.Models.CustomerEntity.CustomerProfile", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsLoggin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerProfiles");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.DeliveryPersonEntitiiy.DeliveryPerson", b =>
                {
                    b.Property<int>("DeliveryPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeliveryPersonId"));

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeliveryPersonId");

                    b.ToTable("DeliveryPersons");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.LoginHistoryEntity.LoginHistoryTable", b =>
                {
                    b.Property<int>("LoginHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginHistoryId"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LoginCount")
                        .HasColumnType("int");

                    b.HasKey("LoginHistoryId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("LoginHistorys");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.MenuEntity.MenuTable", b =>
                {
                    b.Property<string>("MenuItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsAvailable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuItemId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.OrderEntitiy.OrderTable", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DeliveryPerosnId")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DeliveryPerosnId");

                    b.ToTable("OrderTables");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.OrderItemEntity.OrderItemTable", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<string>("MenuItemId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItemTables");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.PaymentEntity.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.PhysicalTableEntity.PhysicalTable", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<bool?>("IsAvailable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReservationEndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReservationStartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<string>("SpecialFeature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.ToTable("PhysicalTables");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.ReservationEntity.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<string>("Occation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("ReservationDate")
                        .HasColumnType("date");

                    b.Property<int>("ReservationDuration")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("ReservationTime")
                        .HasColumnType("time");

                    b.Property<string>("SpecialRequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.LoginHistoryEntity.LoginHistoryTable", b =>
                {
                    b.HasOne("Restuarent_Backend.Models.CustomerEntity.CustomerProfile", "CustomerProfile")
                        .WithOne("LoginHistoryTable")
                        .HasForeignKey("Restuarent_Backend.Models.LoginHistoryEntity.LoginHistoryTable", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProfile");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.OrderEntitiy.OrderTable", b =>
                {
                    b.HasOne("Restuarent_Backend.Models.CustomerEntity.CustomerProfile", "CustomerProfile")
                        .WithMany("OrderTables")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restuarent_Backend.Models.DeliveryPersonEntitiiy.DeliveryPerson", "DeliveryPerson")
                        .WithMany("OrderTables")
                        .HasForeignKey("DeliveryPerosnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProfile");

                    b.Navigation("DeliveryPerson");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.OrderItemEntity.OrderItemTable", b =>
                {
                    b.HasOne("Restuarent_Backend.Models.MenuEntity.MenuTable", "MenuTable")
                        .WithMany("OrderItemTables")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restuarent_Backend.Models.OrderEntitiy.OrderTable", "OrderTable")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuTable");

                    b.Navigation("OrderTable");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.PaymentEntity.Payment", b =>
                {
                    b.HasOne("Restuarent_Backend.Models.OrderEntitiy.OrderTable", "OrderTable")
                        .WithOne("Payment")
                        .HasForeignKey("Restuarent_Backend.Models.PaymentEntity.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderTable");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.ReservationEntity.Reservation", b =>
                {
                    b.HasOne("Restuarent_Backend.Models.CustomerEntity.CustomerProfile", "CustomerProfile")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restuarent_Backend.Models.PhysicalTableEntity.PhysicalTable", "PhysicalTable")
                        .WithMany("Reservations")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProfile");

                    b.Navigation("PhysicalTable");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.CustomerEntity.CustomerProfile", b =>
                {
                    b.Navigation("LoginHistoryTable")
                        .IsRequired();

                    b.Navigation("OrderTables");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.DeliveryPersonEntitiiy.DeliveryPerson", b =>
                {
                    b.Navigation("OrderTables");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.MenuEntity.MenuTable", b =>
                {
                    b.Navigation("OrderItemTables");
                });

            modelBuilder.Entity("Restuarent_Backend.Models.OrderEntitiy.OrderTable", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("Restuarent_Backend.Models.PhysicalTableEntity.PhysicalTable", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
