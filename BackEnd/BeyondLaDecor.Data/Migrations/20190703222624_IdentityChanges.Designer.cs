﻿// <auto-generated />
using System;
using BeyondLaDecor.Beyond.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeyondLaDecor.Data.Migrations
{
    [DbContext(typeof(BeyondDbContext))]
    [Migration("20190703222624_IdentityChanges")]
    partial class IdentityChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("Capacity");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DecorId");

                    b.Property<int>("EventTypeId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("LocationName");

                    b.Property<int?>("PackageId")
                        .IsRequired();

                    b.Property<int?>("TableCount");

                    b.Property<int>("UserId");

                    b.HasKey("EventId");

                    b.HasIndex("EventTypeId");

                    b.HasIndex("UserId");

                    b.HasIndex("PackageId", "EventTypeId", "UserId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.EventType", b =>
                {
                    b.Property<int>("EventTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("EventTypeId");

                    b.HasIndex("EventTypeId", "Name");

                    b.ToTable("EventType");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cost");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("PackageId");

                    b.HasIndex("Name");

                    b.ToTable("Package");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.PackageProduct", b =>
                {
                    b.Property<int>("PackageProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<int>("PackageId");

                    b.Property<int>("ProductId");

                    b.HasKey("PackageProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PackageId", "ProductId");

                    b.ToTable("PackageProduct");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.PackageService", b =>
                {
                    b.Property<int>("PackageServiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<int>("PackageId");

                    b.Property<int>("ServiceId");

                    b.HasKey("PackageServiceId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("PackageId", "ServiceId");

                    b.ToTable("PackageService");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cost");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ProductTypeId");

                    b.Property<int?>("ServiceTypeId");

                    b.Property<bool>("ThirdParty");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("ServiceTypeId");

                    b.HasIndex("Name", "ProductTypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.ProductServiceType", b =>
                {
                    b.Property<int>("ProductServiceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<int>("ProductId");

                    b.Property<int>("ServiceTypeId");

                    b.HasKey("ProductServiceTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ServiceTypeId", "ProductId");

                    b.ToTable("ProductServiceType");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.ProductType", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ProductTypeId");

                    b.HasIndex("Name");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Cost");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ServiceTypeId");

                    b.HasKey("ServiceId");

                    b.HasIndex("ServiceTypeId", "Name");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.ServiceType", b =>
                {
                    b.Property<int>("ServiceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("ParentServiceTypeId");

                    b.HasKey("ServiceTypeId");

                    b.HasIndex("Name");

                    b.HasIndex("ParentServiceTypeId");

                    b.ToTable("ServiceType");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.ServiceVendor", b =>
                {
                    b.Property<int>("ServiceVendorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<int>("ServiceId");

                    b.Property<int>("VendorId");

                    b.HasKey("ServiceVendorId");

                    b.HasIndex("VendorId");

                    b.HasIndex("ServiceId", "VendorId");

                    b.ToTable("ServiceVendor");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("SettingType");

                    b.HasKey("SettingId");

                    b.HasIndex("Name");

                    b.ToTable("Setting");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completed");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<int?>("EventId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("ServiceId");

                    b.HasKey("TaskId");

                    b.HasIndex("EventId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("Name", "ServiceId", "EventId");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<int?>("AdminstratorId");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("DecorId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsAdministrator");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AdminstratorId");

                    b.HasIndex("Email");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.UserSetting", b =>
                {
                    b.Property<int>("UserSettingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId");

                    b.Property<bool>("Enabled");

                    b.Property<int>("SettingId");

                    b.Property<int>("UserId");

                    b.HasKey("UserSettingId");

                    b.HasIndex("ClientId");

                    b.HasIndex("SettingId");

                    b.HasIndex("UserId", "SettingId");

                    b.ToTable("UserSetting");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Vendor", b =>
                {
                    b.Property<int>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("DecorId");

                    b.Property<DateTime>("LastUpdatedOn");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("ServiceTypeId");

                    b.HasKey("VendorId");

                    b.HasIndex("Name");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Event", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.EventType", "EventType")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeId")
                        .HasConstraintName("FK_Event_EventType")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Package", "Package")
                        .WithMany("Events")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("FK_Package_Event")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_Event")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.PackageProduct", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Package", "Package")
                        .WithMany("PackageProducts")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("FK_Package_PackageProduct")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Product", "Product")
                        .WithMany("PackageProducts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Product_PackageProduct")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.PackageService", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Package", "Package")
                        .WithMany("PackageServices")
                        .HasForeignKey("PackageId")
                        .HasConstraintName("FK_Package_PackageService")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Service", "Service")
                        .WithMany("PackageServices")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK_Service_PackageService")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Product", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .HasConstraintName("FK_Product_ProductType")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.ServiceType", "ServiceType")
                        .WithMany("Products")
                        .HasForeignKey("ServiceTypeId")
                        .HasConstraintName("FK_Product_ServiceType")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.ProductServiceType", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Product", "Product")
                        .WithMany("ProductServiceTypes")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_Product_ProductServiceTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.ServiceType", "ServiceType")
                        .WithMany("ProductServiceTypes")
                        .HasForeignKey("ServiceTypeId")
                        .HasConstraintName("FK_ServiceType_ProductServiceTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Service", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.ServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("ServiceTypeId")
                        .HasConstraintName("FK_Service_ServiceType")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.ServiceType", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.ServiceType", "ParentServiceType")
                        .WithMany("ChildServiceTypes")
                        .HasForeignKey("ParentServiceTypeId")
                        .HasConstraintName("FK_Parent_ServiceType")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.ServiceVendor", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Service", "Service")
                        .WithMany("ServiceVendors")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK_ServiceVendor_Service")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Vendor", "Vendor")
                        .WithMany("ServiceVendors")
                        .HasForeignKey("VendorId")
                        .HasConstraintName("FK_ServiceVendor_Vendor")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Task", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Event", "Event")
                        .WithMany("Tasks")
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK_Event_Task")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Service", "Service")
                        .WithMany("Tasks")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK_Service_Task")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.User", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User", "Administrator")
                        .WithMany("Clients")
                        .HasForeignKey("AdminstratorId")
                        .HasConstraintName("FK_Client_Admin")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.UserSetting", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User", "Client")
                        .WithMany("ClientSpecificUserSettings")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Client_UserSetting")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Setting", "Setting")
                        .WithMany("UserSettings")
                        .HasForeignKey("SettingId")
                        .HasConstraintName("FK_UserSetting_Setting")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User", "User")
                        .WithMany("UserSettings")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserSetting_User")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BeyondLaDecor.Beyond.Data.Models.Vendor", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.ServiceType", "ServiceType")
                        .WithMany("Vendors")
                        .HasForeignKey("ServiceTypeId")
                        .HasConstraintName("FK_Vendor_ServiceType")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BeyondLaDecor.Beyond.Data.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
