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
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorType> VendorTypes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageProduct> PackageProduct { get; set; }
        public DbSet<PackageService> PackageServices { get; set; }

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
            new VendorTypeConfiguration(builder.Entity<VendorType>()).Configure();
            new ClientConfiguration(builder.Entity<Client>()).Configure();
            new PackageConfiguration(builder.Entity<Package>()).Configure();
            new PackageProductConfiguration(builder.Entity<PackageProduct>()).Configure();
            new PackageServiceConfiguration(builder.Entity<PackageService>()).Configure();
            base.OnModelCreating(builder);
        }
    }
}