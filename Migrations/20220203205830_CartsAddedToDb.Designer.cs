﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet_5_Web_Api_Portfolio_Project.Data;

namespace dotnet_5_Web_Api_Portfolio_Project.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220203205830_CartsAddedToDb")]
    partial class CartsAddedToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("dotnet_5_Web_Api_Portfolio_Project.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("dotnet_5_Web_Api_Portfolio_Project.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte>("Amount")
                        .HasColumnType("tinyint");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Ratting")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("dotnet_5_Web_Api_Portfolio_Project.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGolden")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSubcribed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PassowrdSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("dotnet_5_Web_Api_Portfolio_Project.Models.Cart", b =>
                {
                    b.HasOne("dotnet_5_Web_Api_Portfolio_Project.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("dotnet_5_Web_Api_Portfolio_Project.Models.Item", b =>
                {
                    b.HasOne("dotnet_5_Web_Api_Portfolio_Project.Models.Cart", null)
                        .WithMany("ItemList")
                        .HasForeignKey("CartId");
                });

            modelBuilder.Entity("dotnet_5_Web_Api_Portfolio_Project.Models.Cart", b =>
                {
                    b.Navigation("ItemList");
                });
#pragma warning restore 612, 618
        }
    }
}