using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class VendorConfiguration : ConfigurationBase<Vendor>
    {
        private EntityTypeBuilder<Vendor> entityTypeBuilder;

        public VendorConfiguration(EntityTypeBuilder<Vendor> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Vendor> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasIndex(e => e.Name);
        }

        public override void ConfigureProperties(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasKey(e => e.VendorId);
            builder.Property(e => e.ServiceTypeId).IsRequired();
            builder.Property(e => e.Name).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasMany(e => e.ServiceVendors)
                .WithOne(e => e.Vendor)
                .HasForeignKey(e => e.VendorId)
                .HasConstraintName("FK_ServiceVendor_Vendor");
            builder.HasOne(e => e.ServiceType)
              .WithMany(e => e.Vendors)
              .HasForeignKey(e => e.ServiceTypeId)
              .HasConstraintName("FK_Vendor_ServiceType");
        }
    }
}