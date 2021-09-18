﻿// <auto-generated />
using System;
using CarRentalManagement.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRentalManagement.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210916025046_CreateUserDefault")]
    partial class CreateUserDefault
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRentalManagement.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "748b708f-69a3-45b5-b520-a95fe1417016",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9cc2eb1d-5763-4a46-a5f8-b2e8afdb2994",
                            Email = "yeli@gmail.com",
                            EmailConfirmed = false,
                            FistName = "System",
                            LastName = "Admin",
                            LockoutEnabled = true,
                            NormalizedEmail = "YELI@GMAIL.COM",
                            NormalizedUserName = "YELI@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFDzgCvx1ckXwBLnOiH+BkSiXrnDDnc4Zx3SXx+kC/4hTAF8lEPt4Xk/1/u5UtIgnA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "afb7de8a-945d-4547-a659-f5d48a8e75cc",
                            TwoFactorEnabled = false,
                            UserName = "yeli@gmail.com"
                        },
                        new
                        {
                            Id = "748b708f-69a3-45b5-b520-a95fe1417017",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bc4492b4-bbe2-4b22-af4e-b74788b10828",
                            Email = "adael@gmail.com",
                            EmailConfirmed = false,
                            FistName = "System",
                            LastName = "User",
                            LockoutEnabled = true,
                            NormalizedEmail = "ADAEL@GMAIL.COM",
                            NormalizedUserName = "ADAEL@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBkPa0ekrofVny7r5tjFj9jVkuwamBrJb+uMpoC7e9euIEq8+2MqXrWjaRMSXfGz8g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a3dc5dfb-8a25-4a3a-a1e9-8b6db1689dfe",
                            TwoFactorEnabled = false,
                            UserName = "adael@gmail.com"
                        });
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Colour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Colours");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 970, DateTimeKind.Local).AddTicks(5367),
                            Name = "RED",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8163)
                        },
                        new
                        {
                            Id = 2,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8766),
                            Name = "BLACK",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8779)
                        },
                        new
                        {
                            Id = 3,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8784),
                            Name = "BLUE",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8786)
                        },
                        new
                        {
                            Id = 4,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8789),
                            Name = "WHITE",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 972, DateTimeKind.Local).AddTicks(8791)
                        });
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1912),
                            Name = "Toyota",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1936)
                        },
                        new
                        {
                            Id = 2,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1941),
                            Name = "BMW",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1943)
                        },
                        new
                        {
                            Id = 3,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1946),
                            Name = "Ferrari",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1949)
                        },
                        new
                        {
                            Id = 4,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1952),
                            Name = "AUDI",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1954)
                        },
                        new
                        {
                            Id = 5,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1956),
                            Name = "Lada",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(1959)
                        });
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6804),
                            Name = "Auris",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6828)
                        },
                        new
                        {
                            Id = 2,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6833),
                            Name = "Avensis",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6836)
                        },
                        new
                        {
                            Id = 3,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6839),
                            Name = "Enso",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6841)
                        },
                        new
                        {
                            Id = 4,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6844),
                            Name = "A1",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6846)
                        },
                        new
                        {
                            Id = 5,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6849),
                            Name = "A8",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6851)
                        },
                        new
                        {
                            Id = 6,
                            CreateBy = "System",
                            CreateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6854),
                            Name = "2107",
                            UpdateBy = "System",
                            UpdateDate = new DateTime(2021, 9, 15, 22, 50, 45, 974, DateTimeKind.Local).AddTicks(6856)
                        });
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColourId")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LicensePlaterNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<double>("RentalRate")
                        .HasColumnType("float");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Vin")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColourId");

                    b.HasIndex("MakeId");

                    b.HasIndex("ModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "891c0721-f23b-49c2-bbda-3e59b0c20f38",
                            ConcurrencyStamp = "dfcb8561-4e6b-4799-b2e7-924bbe6ff403",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "5d61cf78-e527-43bd-92ec-35518c889ac9",
                            ConcurrencyStamp = "9d152a5b-32de-4a5c-a0c1-a7a973323d91",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Booking", b =>
                {
                    b.HasOne("CarRentalManagement.Shared.Domain.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalManagement.Shared.Domain.Vehicle", "Vehicle")
                        .WithMany("Bookings")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Vehicle", b =>
                {
                    b.HasOne("CarRentalManagement.Shared.Domain.Colour", "Colour")
                        .WithMany()
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalManagement.Shared.Domain.Make", "Make")
                        .WithMany()
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalManagement.Shared.Domain.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colour");

                    b.Navigation("Make");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarRentalManagement.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarRentalManagement.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalManagement.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarRentalManagement.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("CarRentalManagement.Shared.Domain.Vehicle", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
