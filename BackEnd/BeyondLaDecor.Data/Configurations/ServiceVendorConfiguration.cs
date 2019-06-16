using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class ServiceVendorConfiguration : ConfigurationBase<ServiceVendor>
    {
        private EntityTypeBuilder<ServiceVendor> entityTypeBuilder;

        public ServiceVendorConfiguration(EntityTypeBuilder<ServiceVendor> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<ServiceVendor> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<ServiceVendor> builder)
        {
            builder.HasIndex(e => new { e.ServiceId, e.VendorId});
        }

        public override void ConfigureProperties(EntityTypeBuilder<ServiceVendor> builder)
        {
            builder.HasKey(e => e.ServiceVendorId);
            builder.Property(e => e.ServiceId).IsRequired();
            builder.Property(e => e.VendorId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<ServiceVendor> builder)
        {
            builder.HasOne(e => e.Service)
                .WithMany(e => e.ServiceVendors)
                .HasForeignKey(e => e.ServiceId)
                .HasConstraintName("FK_ServiceVendor_Service").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Vendor)
              .WithMany(e => e.ServiceVendors)
              .HasForeignKey(e => e.VendorId)
              .HasConstraintName("FK_ServiceVendor_Vendor").OnDelete(DeleteBehavior.Restrict);
        }
    }
}