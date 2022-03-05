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
    [Migration("20220305073918_ModelRevisions6")]
    partial class ModelRevisions6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("UnitId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("XCompany_api.Models.EmployeeMonthlyPlan", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("MonthlyPlanMonth")
                        .HasColumnType("int");

                    b.Property<int?>("MonthlyPlanYear")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("MonthlyPlanYear", "MonthlyPlanMonth");

                    b.ToTable("EmployeeMonthlyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.EmployeeWeeklyPlan", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("WeeklyPlanid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("WeeklyPlanid");

                    b.ToTable("EmployeeWeeklyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.EmployeeYearlyPlan", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("YearlyPlanYearId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("YearlyPlanYearId");

                    b.ToTable("EmployeeYearlyPlans");
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

                    b.Property<int?>("WeeklyPlanid")
                        .HasColumnType("int");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("WeeklyPlanid");

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
                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.Property<int?>("Month")
                        .HasColumnType("int");

                    b.Property<int?>("YearlyPlanYearId")
                        .HasColumnType("int");

                    b.HasKey("Year", "Month");

                    b.HasIndex("YearlyPlanYearId");

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

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ItemQuantityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ItemQuantityId");

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
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Customers")
                        .HasColumnType("int");

                    b.Property<int?>("MonthlyPlanMonth")
                        .HasColumnType("int");

                    b.Property<int?>("MonthlyPlanYear")
                        .HasColumnType("int");

                    b.Property<double?>("Total")
                        .HasColumnType("double");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.Property<int?>("month")
                        .HasColumnType("int");

                    b.Property<int?>("week")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("MonthlyPlanYear", "MonthlyPlanMonth");

                    b.ToTable("WeeklyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.YearlyPlan", b =>
                {
                    b.Property<int?>("YearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("YearId");

                    b.ToTable("YearlyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.Employee", b =>
                {
                    b.HasOne("XCompany_api.Models.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId");

                    b.HasOne("XCompany_api.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");

                    b.Navigation("Office");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("XCompany_api.Models.EmployeeMonthlyPlan", b =>
                {
                    b.HasOne("XCompany_api.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("XCompany_api.Models.MonthlyPlan", "MonthlyPlan")
                        .WithMany()
                        .HasForeignKey("MonthlyPlanYear", "MonthlyPlanMonth");

                    b.Navigation("Employee");

                    b.Navigation("MonthlyPlan");
                });

            modelBuilder.Entity("XCompany_api.Models.EmployeeWeeklyPlan", b =>
                {
                    b.HasOne("XCompany_api.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("XCompany_api.Models.WeeklyPlan", "WeeklyPlan")
                        .WithMany()
                        .HasForeignKey("WeeklyPlanid");

                    b.Navigation("Employee");

                    b.Navigation("WeeklyPlan");
                });

            modelBuilder.Entity("XCompany_api.Models.EmployeeYearlyPlan", b =>
                {
                    b.HasOne("XCompany_api.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("XCompany_api.Models.YearlyPlan", "YearlyPlan")
                        .WithMany()
                        .HasForeignKey("YearlyPlanYearId");

                    b.Navigation("Employee");

                    b.Navigation("YearlyPlan");
                });

            modelBuilder.Entity("XCompany_api.Models.ItemQuantity", b =>
                {
                    b.HasOne("XCompany_api.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("XCompany_api.Models.WeeklyPlan", null)
                        .WithMany("ItemQuantities")
                        .HasForeignKey("WeeklyPlanid");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("XCompany_api.Models.MonthlyPlan", b =>
                {
                    b.HasOne("XCompany_api.Models.YearlyPlan", null)
                        .WithMany("MonthlyPlans")
                        .HasForeignKey("YearlyPlanYearId");
                });

            modelBuilder.Entity("XCompany_api.Models.Sale", b =>
                {
                    b.HasOne("XCompany_api.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("XCompany_api.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XCompany_api.Models.ItemQuantity", "ItemQuantity")
                        .WithMany()
                        .HasForeignKey("ItemQuantityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("ItemQuantity");
                });

            modelBuilder.Entity("XCompany_api.Models.WeeklyPlan", b =>
                {
                    b.HasOne("XCompany_api.Models.MonthlyPlan", null)
                        .WithMany("WeeklyPlans")
                        .HasForeignKey("MonthlyPlanYear", "MonthlyPlanMonth");
                });

            modelBuilder.Entity("XCompany_api.Models.MonthlyPlan", b =>
                {
                    b.Navigation("WeeklyPlans");
                });

            modelBuilder.Entity("XCompany_api.Models.WeeklyPlan", b =>
                {
                    b.Navigation("ItemQuantities");
                });

            modelBuilder.Entity("XCompany_api.Models.YearlyPlan", b =>
                {
                    b.Navigation("MonthlyPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
