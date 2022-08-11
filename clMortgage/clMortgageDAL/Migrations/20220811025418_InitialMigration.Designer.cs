﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using clMortgageDAL.DataContext;

#nullable disable

namespace clMortgageDAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220811025418_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("BusinessService.Model.LoanDetail", b =>
                {
                    b.Property<Guid?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedON")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GrossSalary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("LoanPurpose")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ModifiedById")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedON")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PropertyLocationid")
                        .HasColumnType("TEXT");

                    b.Property<int>("SalariedRecived")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Source")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WorkingCompany")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("PropertyLocationid");

                    b.ToTable("LoanModels");
                });

            modelBuilder.Entity("BusinessService.Model.Location", b =>
                {
                    b.Property<Guid?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("HuseNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("PinNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("BusinessService.Model.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BusinessService.Model.LoanDetail", b =>
                {
                    b.HasOne("BusinessService.Model.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("BusinessService.Model.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("BusinessService.Model.Location", "PropertyLocation")
                        .WithMany()
                        .HasForeignKey("PropertyLocationid");

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");

                    b.Navigation("PropertyLocation");
                });
#pragma warning restore 612, 618
        }
    }
}
