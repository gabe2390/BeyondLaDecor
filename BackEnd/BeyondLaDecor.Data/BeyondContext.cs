using BeyondLaDecor.Beyond.Data.Configurations;
using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BeyondLaDecor.Beyond.Data
{
    public class BeyondDbContext : DbContext
    {
        private const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BeyondLaDecor;";

        //Models
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServiceVendor> ServiceVendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageProduct> PackageProduct { get; set; }
        public DbSet<PackageService> PackageServices { get; set; }
        public DbSet<ProductServiceType> ProductServiceTypes { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }

        public BeyondDbContext(DbContextOptions<BeyondDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTION_STRING);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new EventConfiguration(builder.Entity<Event>()).Configure();
            new EventTypeConfiguration(builder.Entity<EventType>()).Configure();
            new ServiceConfiguration(builder.Entity<Service>()).Configure();
            new ServiceTypeConfiguration(builder.Entity<ServiceType>()).Configure();
            new ProductConfiguration(builder.Entity<Product>()).Configure();
            new ProductTypeConfiguration(builder.Entity<ProductType>()).Configure();
            new VendorConfiguration(builder.Entity<Vendor>()).Configure();
            new ServiceVendorConfiguration(builder.Entity<ServiceVendor>()).Configure();
            new UserConfiguration(builder.Entity<User>()).Configure();
            new PackageConfiguration(builder.Entity<Package>()).Configure();
            new PackageProductConfiguration(builder.Entity<PackageProduct>()).Configure();
            new PackageServiceConfiguration(builder.Entity<PackageService>()).Configure();
            new ProductServiceTypeConfiguration(builder.Entity<ProductServiceType>()).Configure();
            new TaskConfiguration(builder.Entity<Task>()).Configure();
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified) && e.Properties.Any(p => p.Metadata.Name == "LastUpdatedOn")))
            {
                //Temporarily will update CreatedBy and LastUpdatedBy to PersonId but will eventually replace this with method to get the LogonName from Authorization
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedOn").CurrentValue = DateTime.UtcNow;
                }
                else
                {
                    entry.Property("LastUpdatedOn").CurrentValue = DateTime.UtcNow;
                }
            }
            return base.SaveChanges();
        }
    }
}