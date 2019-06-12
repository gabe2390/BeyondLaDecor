using BeyondLaDecor.Beyond.Data.Configurations;
using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data
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
            throw new System.NotImplementedException();
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Vendor> builder)
        {
            throw new System.NotImplementedException();
        }

        public override void ConfigureProperties(EntityTypeBuilder<Vendor> builder)
        {
            throw new System.NotImplementedException();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Vendor> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}