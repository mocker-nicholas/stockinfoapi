﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using stockInfoApi.Data;

#nullable disable

namespace stockInfoApi.Migrations
{
    [DbContext(typeof(DevDbContext))]
    partial class DevDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("stockInfoApi.Models.DboModels.AccountDbo", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("stockInfoApi.Models.DboModels.StockDbo", b =>
                {
                    b.Property<Guid>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumShares")
                        .HasColumnType("int");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<double>("SharePrice")
                        .HasColumnType("float");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StockId");

                    b.HasIndex("AccountId1");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("stockInfoApi.Models.DboModels.TransactionDbo", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountDboAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumShares")
                        .HasColumnType("int");

                    b.Property<double>("SharePrice")
                        .HasColumnType("float");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("TransactionId");

                    b.HasIndex("AccountDboAccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("stockInfoApi.Models.DboModels.StockDbo", b =>
                {
                    b.HasOne("stockInfoApi.Models.DboModels.AccountDbo", "AccountId")
                        .WithMany("Stocks")
                        .HasForeignKey("AccountId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountId");
                });

            modelBuilder.Entity("stockInfoApi.Models.DboModels.TransactionDbo", b =>
                {
                    b.HasOne("stockInfoApi.Models.DboModels.AccountDbo", null)
                        .WithMany("Transactions")
                        .HasForeignKey("AccountDboAccountId");
                });

            modelBuilder.Entity("stockInfoApi.Models.DboModels.AccountDbo", b =>
                {
                    b.Navigation("Stocks");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
