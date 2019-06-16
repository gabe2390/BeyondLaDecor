using BeyondLaDecor.Beyond.Data.Configurations;
using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;

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
            base.OnModelCreating(builder);
        }
    }
}