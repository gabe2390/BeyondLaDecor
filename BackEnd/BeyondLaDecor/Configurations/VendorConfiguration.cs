using BeyondLaDecor.Beyond.Data.Configurations;
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
            builder.Property(e => e.VendorTypeId).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.ServiceId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasOne(e => e.Service)
                .WithMany(e => e.Vendors)
                .HasForeignKey(e => e.ServiceId)
                .HasConstraintName("FK_Service_Vendor");
            builder.HasOne(e => e.VendorType)
              .WithMany(e => e.Vendors)
              .HasForeignKey(e => e.VendorTypeId)
              .HasConstraintName("FK_VendorType_Vendor");
        }
    }
}