﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACar.Data;

#nullable disable

namespace RentACar.Migrations
{
    [DbContext(typeof(RentACarContext))]
    [Migration("20240113142035_CarBorrowings")]
    partial class CarBorrowings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RentACar.Models.Borrowing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CarID")
                        .HasColumnType("int");

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.HasIndex("ClientID");

                    b.ToTable("Borrowing");
                });

            modelBuilder.Entity("RentACar.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CollectionID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("RenterID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CollectionID");

                    b.HasIndex("RenterID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("RentACar.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("RentACar.Models.Collection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("RentACar.Models.Renter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("RenterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Renter");
                });

            modelBuilder.Entity("RentACar.Models.Borrowing", b =>
                {
                    b.HasOne("RentACar.Models.Car", "Car")
                        .WithMany("Borrowings")
                        .HasForeignKey("CarID");

                    b.HasOne("RentACar.Models.Client", "Client")
                        .WithMany("Borrowings")
                        .HasForeignKey("ClientID");

                    b.Navigation("Car");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("RentACar.Models.Car", b =>
                {
                    b.HasOne("RentACar.Models.Collection", "Collection")
                        .WithMany("Cars")
                        .HasForeignKey("CollectionID");

                    b.HasOne("RentACar.Models.Renter", "Renter")
                        .WithMany("Cars")
                        .HasForeignKey("RenterID");

                    b.Navigation("Collection");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("RentACar.Models.Car", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("RentACar.Models.Client", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("RentACar.Models.Collection", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("RentACar.Models.Renter", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
