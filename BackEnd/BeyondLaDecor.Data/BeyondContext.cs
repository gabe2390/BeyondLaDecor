using BeyondLaDecor.Beyond.Data.Configurations;
using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BeyondLaDecor.Beyond.Data
{
    public class BeyondDbContext : IdentityDbContext<User, Role, int>
    {
        private const string CONNECTION_STRING = "Data Source=(localdb)\\MSSQLLocalDB; Initial catalog=BeyondLaDecor;";

        //Models
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServiceVendor> ServiceVendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
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
            IdentityConfig(builder);
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
            new SettingConfiguration(builder.Entity<Setting>()).Configure();
            new UserSettingConfiguration(builder.Entity<UserSetting>()).Configure();
            new LocationConfiguration(builder.Entity<Location>()).Configure();
            new InventoryConfiguration(builder.Entity<Inventory>()).Configure();
            new InventoryRecordConfiguration(builder.Entity<InventoryRecord>()).Configure();
            base.OnModelCreating(builder);
        }
        //TODO: this doesn't work at the moment, the tables are still being names AspNet...
        private void IdentityConfig(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("Users");
            builder.Entity<Role>().ToTable("Roles");
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserToken");
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified) && e.Properties.Any(p => p.Metadata.Name == "LastUpdatedOn")))
            {
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