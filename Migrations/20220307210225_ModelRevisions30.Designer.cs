﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XCompany_api.Data;

#nullable disable

namespace XCompany_api.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20220307210225_ModelRevisions30")]
    partial class ModelRevisions30
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("IdentityRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("IdentityUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRoles");
                });

            modelBuilder.Entity("XCompany_api.Models.Capability", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Plans")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Capabilities");
                });

            modelBuilder.Entity("XCompany_api.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("XCompany_api.Models.Employee", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Username");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("XCompany_api.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double?>("Price")
                        .HasColumnType("double");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("XCompany_api.Models.ItemQuantity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int?>("MonthlyPlanId")
                        .HasColumnType("int");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.Property<int?>("WeeklyPlanId")
                        .HasColumnType("int");

                    b.Property<int?>("YearlyPlanId")
                        .HasColumnType("int");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MonthlyPlanId");

                    b.HasIndex("SaleId");

                    b.HasIndex("WeeklyPlanId");

                    b.HasIndex("YearlyPlanId");

                    b.ToTable("ItemQuantities");
                });

            modelBuilder.Entity("XCompany_api.Models.LoginModel", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Username");

                    b.ToTable("LoginModels");
                });

            modelBuilder.Entity("XCompany_api.Models.MonthlyPlan", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Customers")
                        .HasColumnType("int");

                    b.Property<int?>("Month")
                        .HasColumnType("int");

                    b.Property<double?>("Total")
                        .HasColumnType("double");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MonthlyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("XCompany_api.Models.RegisterModel", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.HasKey("Username");

                    b.ToTable("RegisterModels");
                });

            modelBuilder.Entity("XCompany_api.Models.Response", b =>
                {
                    b.Property<string>("Status")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext");

                    b.HasKey("Status");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("XCompany_api.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("unitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("XCompany_api.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("XCompany_api.Models.WeeklyPlan", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Customers")
                        .HasColumnType("int");

                    b.Property<int?>("Month")
                        .HasColumnType("int");

                    b.Property<double?>("Total")
                        .HasColumnType("double");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<int?>("Week")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeeklyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.YearlyPlan", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("Customers")
                        .HasColumnType("int");

                    b.Property<double?>("Total")
                        .HasColumnType("double");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("YearlyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.ItemQuantity", b =>
                {
                    b.HasOne("XCompany_api.Models.MonthlyPlan", null)
                        .WithMany("ItemQuantities")
                        .HasForeignKey("MonthlyPlanId");

                    b.HasOne("XCompany_api.Models.Sale", null)
                        .WithMany("ItemQuantity")
                        .HasForeignKey("SaleId");

                    b.HasOne("XCompany_api.Models.WeeklyPlan", null)
                        .WithMany("ItemQuantities")
                        .HasForeignKey("WeeklyPlanId");

                    b.HasOne("XCompany_api.Models.YearlyPlan", null)
                        .WithMany("ItemQuantities")
                        .HasForeignKey("YearlyPlanId");
                });

            modelBuilder.Entity("XCompany_api.Models.MonthlyPlan", b =>
                {
                    b.Navigation("ItemQuantities");
                });

            modelBuilder.Entity("XCompany_api.Models.Sale", b =>
                {
                    b.Navigation("ItemQuantity");
                });

            modelBuilder.Entity("XCompany_api.Models.WeeklyPlan", b =>
                {
                    b.Navigation("ItemQuantities");
                });

            modelBuilder.Entity("XCompany_api.Models.YearlyPlan", b =>
                {
                    b.Navigation("ItemQuantities");
                });
#pragma warning restore 612, 618
        }
    }
}
