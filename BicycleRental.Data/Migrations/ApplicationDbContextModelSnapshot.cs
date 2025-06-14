﻿// <auto-generated />
using System;
using BicycleRental.WebAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BicycleRental.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BicycleRental.Domain.Entities.Bike", b =>
                {
                    b.Property<int>("IdBike")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdBike"));

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Number")
                        .HasMaxLength(30)
                        .HasColumnType("integer");

                    b.HasKey("IdBike");

                    b.ToTable("bikes", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdClient"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RentCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdClient");

                    b.ToTable("clients", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Discount", b =>
                {
                    b.Property<int>("IdDiscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdDiscount"));

                    b.Property<int>("Allowed")
                        .HasColumnType("integer");

                    b.Property<int>("IdRent")
                        .HasColumnType("integer");

                    b.Property<string>("Name_discount")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Percent")
                        .HasColumnType("double precision");

                    b.HasKey("IdDiscount");

                    b.HasIndex("IdRent")
                        .IsUnique();

                    b.ToTable("discounts", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Duty", b =>
                {
                    b.Property<int>("IdDuty")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateDuty")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("SumDuty")
                        .HasColumnType("numeric");

                    b.HasKey("IdDuty");

                    b.ToTable("dutys", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("IdEmployee")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdEmployee");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.PayCheck", b =>
                {
                    b.Property<int>("IdPaycheck")
                        .HasColumnType("integer");

                    b.HasKey("IdPaycheck");

                    b.ToTable("pay_chek", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Place", b =>
                {
                    b.Property<int>("IdPlace")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdPlace"));

                    b.Property<bool>("ChoosePlace")
                        .HasColumnType("boolean");

                    b.Property<double>("Distance")
                        .HasColumnType("double precision");

                    b.Property<string>("NamePlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdPlace");

                    b.ToTable("place", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Rent", b =>
                {
                    b.Property<int>("IdRent")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataRent")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdPlace")
                        .HasColumnType("integer");

                    b.Property<TimeSpan>("RentTime")
                        .HasColumnType("interval");

                    b.HasKey("IdRent");

                    b.HasIndex("IdPlace")
                        .IsUnique();

                    b.ToTable("Rent", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Rents_accept", b =>
                {
                    b.Property<int>("IdRentAccept")
                        .HasColumnType("integer");

                    b.Property<bool>("Accepted")
                        .HasColumnType("boolean");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("integer");

                    b.HasKey("IdRentAccept");

                    b.ToTable("rents_accept", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Repair", b =>
                {
                    b.Property<int>("IdRepairBike")
                        .HasColumnType("integer");

                    b.Property<string>("CommentRepair")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("StatusBike")
                        .HasColumnType("boolean");

                    b.Property<int>("TypeRepair")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.HasKey("IdRepairBike");

                    b.ToTable("repairs", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Stoping", b =>
                {
                    b.Property<int>("IdStop")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("IdStop");

                    b.ToTable("stoping", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.User", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("IdUser");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Discount", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Rent", "Rents")
                        .WithOne("Discounts")
                        .HasForeignKey("BicycleRental.Domain.Entities.Discount", "IdRent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rents");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Duty", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Client", "Clients")
                        .WithMany("Duty")
                        .HasForeignKey("IdDuty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Employee", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.PayCheck", "PayCheckBike")
                        .WithMany("Employee")
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleRental.Domain.Entities.Rents_accept", "Rents_accept")
                        .WithMany("Employee")
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleRental.Domain.Entities.Repair", "Repair_Bike")
                        .WithMany("Employee")
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PayCheckBike");

                    b.Navigation("Rents_accept");

                    b.Navigation("Repair_Bike");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.PayCheck", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Duty", "Duties")
                        .WithMany("PayCheck")
                        .HasForeignKey("IdPaycheck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Duties");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Rent", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Place", "Places")
                        .WithOne("Rents")
                        .HasForeignKey("BicycleRental.Domain.Entities.Rent", "IdPlace")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleRental.Domain.Entities.Bike", "Bikes")
                        .WithMany("Rent")
                        .HasForeignKey("IdRent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bikes");

                    b.Navigation("Places");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Rents_accept", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Rent", "Rents")
                        .WithMany("Rents_accept")
                        .HasForeignKey("IdRentAccept")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rents");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Repair", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Bike", "Bikes")
                        .WithMany("Repair")
                        .HasForeignKey("IdRepairBike")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bikes");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Stoping", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Place", "Places")
                        .WithMany("Stoping")
                        .HasForeignKey("IdStop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Places");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.User", b =>
                {
                    b.HasOne("BicycleRental.Domain.Entities.Client", "Clients")
                        .WithMany("Users")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleRental.Domain.Entities.Employee", "Employees")
                        .WithMany("Users")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BicycleRental.Domain.Entities.Rent", "Rents")
                        .WithMany("Users")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");

                    b.Navigation("Employees");

                    b.Navigation("Rents");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Bike", b =>
                {
                    b.Navigation("Rent");

                    b.Navigation("Repair");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Client", b =>
                {
                    b.Navigation("Duty");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Duty", b =>
                {
                    b.Navigation("PayCheck");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.PayCheck", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Place", b =>
                {
                    b.Navigation("Rents")
                        .IsRequired();

                    b.Navigation("Stoping");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Rent", b =>
                {
                    b.Navigation("Discounts")
                        .IsRequired();

                    b.Navigation("Rents_accept");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Rents_accept", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BicycleRental.Domain.Entities.Repair", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
