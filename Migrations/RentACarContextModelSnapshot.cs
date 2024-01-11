﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACar.Data;

#nullable disable

namespace RentACar.Migrations
{
    [DbContext(typeof(RentACarContext))]
    partial class RentACarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RentACar.Models.Car", b =>
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("RenterID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RenterID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("RentACar.Models.CarCollection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("CollectionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.HasIndex("CollectionID");

                    b.ToTable("CarCollection");
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

            modelBuilder.Entity("RentACar.Models.Car", b =>
                {
                    b.HasOne("RentACar.Models.Renter", "Renter")
                        .WithMany("Cars")
                        .HasForeignKey("RenterID");

                    b.Navigation("Renter");
                });

            modelBuilder.Entity("RentACar.Models.CarCollection", b =>
                {
                    b.HasOne("RentACar.Models.Car", "Car")
                        .WithMany("CarCollections")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACar.Models.Collection", "Collection")
                        .WithMany("CarCollections")
                        .HasForeignKey("CollectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Collection");
                });

            modelBuilder.Entity("RentACar.Models.Car", b =>
                {
                    b.Navigation("CarCollections");
                });

            modelBuilder.Entity("RentACar.Models.Collection", b =>
                {
                    b.Navigation("CarCollections");
                });

            modelBuilder.Entity("RentACar.Models.Renter", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
