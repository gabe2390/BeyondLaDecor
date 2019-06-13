using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class VendorTypeConfiguration : ConfigurationBase<VendorType>
    {
        private EntityTypeBuilder<VendorType> entityTypeBuilder;

        public VendorTypeConfiguration(EntityTypeBuilder<VendorType> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<VendorType> builder)
        {
            throw new System.NotImplementedException();
        }

        public override void ConfigureIndexes(EntityTypeBuilder<VendorType> builder)
        {
            builder.HasIndex(e => e.TypeName);
        }

        public override void ConfigureProperties(EntityTypeBuilder<VendorType> builder)
        {
            builder.HasKey(e => e.VendorTypeId);
            builder.Property(e => e.TypeName).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<VendorType> builder)
        {
            builder.HasMany(e => e.Vendors)
                .WithOne(e => e.VendorType)
                .HasForeignKey(e => e.VendorTypeId)
                .HasConstraintName("FK_VendorType_Vendor");
        }
    }
}