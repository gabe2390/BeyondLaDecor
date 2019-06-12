using BeyondLaDecor.Data.Models;
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
            throw new System.NotImplementedException();
        }

        public override void ConfigureProperties(EntityTypeBuilder<VendorType> builder)
        {
            throw new System.NotImplementedException();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<VendorType> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}