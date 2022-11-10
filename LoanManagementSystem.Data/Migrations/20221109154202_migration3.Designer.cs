﻿// <auto-generated />
using System;
using LoanManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoanManagementSystem.Data.Migrations
{
    [DbContext(typeof(LMSContext))]
    [Migration("20221109154202_migration3")]
    partial class migration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LoanManagementSystem.Models.BankDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BankAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BankDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BankAddress = "Kondapur",
                            BankName = "Kondapur Branch MyBank"
                        },
                        new
                        {
                            Id = 2,
                            BankAddress = "Madhapur",
                            BankName = "Kondapur Branch MyBank"
                        },
                        new
                        {
                            Id = 3,
                            BankAddress = "Hitech",
                            BankName = "Kondapur Branch MyBank"
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.CustomerInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Custname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phoneno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerInfos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustAddress = "address",
                            Custname = "Rohit",
                            Email = "email@email.com",
                            Pan = "6846asdf",
                            Phoneno = "9876543210"
                        },
                        new
                        {
                            Id = 2,
                            CustAddress = "address",
                            Custname = "Ria",
                            Email = "email@email.com",
                            Pan = "6846asdf",
                            Phoneno = "9876543210"
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.Emi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<float>("AmountTaken")
                        .HasColumnType("real");

                    b.Property<int>("CustomerInfoId")
                        .HasColumnType("int");

                    b.Property<bool>("EmiCompleted")
                        .HasColumnType("bit");

                    b.Property<float>("Interest")
                        .HasColumnType("real");

                    b.Property<int>("LoanTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Months")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerInfoId");

                    b.HasIndex("LoanTypeId");

                    b.ToTable("Emis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1000000f,
                            AmountTaken = 0f,
                            CustomerInfoId = 1,
                            EmiCompleted = false,
                            Interest = 10f,
                            LoanTypeId = 1,
                            Months = 12,
                            StartDate = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amount = 5000000f,
                            AmountTaken = 0f,
                            CustomerInfoId = 2,
                            EmiCompleted = false,
                            Interest = 10f,
                            LoanTypeId = 1,
                            Months = 24,
                            StartDate = new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.EmiPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("EmiAmount")
                        .HasColumnType("real");

                    b.Property<int>("EmiId")
                        .HasColumnType("int");

                    b.Property<float>("Fine")
                        .HasColumnType("real");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PaidOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmiId");

                    b.ToTable("Emipayments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmiAmount = 83333f,
                            EmiId = 1,
                            Fine = 0f,
                            IssueDate = new DateTime(2022, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaidOn = new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EmiAmount = 83333f,
                            EmiId = 1,
                            Fine = 0f,
                            IssueDate = new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaidOn = new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EmiAmount = 208333f,
                            EmiId = 2,
                            Fine = 0f,
                            IssueDate = new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaidOn = new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("BankDetailId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerInfoId")
                        .HasColumnType("int");

                    b.Property<float>("Interest")
                        .HasColumnType("real");

                    b.Property<int>("LoanTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Months")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankDetailId");

                    b.HasIndex("CustomerInfoId");

                    b.HasIndex("LoanTypeId");

                    b.ToTable("LoanApplications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 1000000f,
                            BankDetailId = 1,
                            CustomerInfoId = 1,
                            Interest = 12f,
                            LoanTypeId = 2,
                            Months = 12,
                            status = 0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100000f,
                            BankDetailId = 2,
                            CustomerInfoId = 1,
                            Interest = 8f,
                            LoanTypeId = 3,
                            Months = 24,
                            status = 0
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("InterestRate")
                        .HasColumnType("real");

                    b.Property<string>("LoanTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoanTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InterestRate = 10f,
                            LoanTypeName = "Gold_Loan"
                        },
                        new
                        {
                            Id = 2,
                            InterestRate = 12f,
                            LoanTypeName = "Home_Loan"
                        },
                        new
                        {
                            Id = 3,
                            InterestRate = 8f,
                            LoanTypeName = "Personal_Loan"
                        });
                });

            modelBuilder.Entity("LoanManagementSystem.Models.Emi", b =>
                {
                    b.HasOne("LoanManagementSystem.Models.CustomerInfo", "Cust")
                        .WithMany("Emis")
                        .HasForeignKey("CustomerInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoanManagementSystem.Models.LoanType", "LoanType")
                        .WithMany()
                        .HasForeignKey("LoanTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cust");

                    b.Navigation("LoanType");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.EmiPayment", b =>
                {
                    b.HasOne("LoanManagementSystem.Models.Emi", "Emi")
                        .WithMany("EmiPayments")
                        .HasForeignKey("EmiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emi");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.LoanApplication", b =>
                {
                    b.HasOne("LoanManagementSystem.Models.BankDetail", "BankDetail")
                        .WithMany()
                        .HasForeignKey("BankDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoanManagementSystem.Models.CustomerInfo", "Cust")
                        .WithMany("LoanApplications")
                        .HasForeignKey("CustomerInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoanManagementSystem.Models.LoanType", "LoanType")
                        .WithMany()
                        .HasForeignKey("LoanTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankDetail");

                    b.Navigation("Cust");

                    b.Navigation("LoanType");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.CustomerInfo", b =>
                {
                    b.Navigation("Emis");

                    b.Navigation("LoanApplications");
                });

            modelBuilder.Entity("LoanManagementSystem.Models.Emi", b =>
                {
                    b.Navigation("EmiPayments");
                });
#pragma warning restore 612, 618
        }
    }
}
