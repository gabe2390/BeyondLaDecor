using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class ProductServiceTypeConfiguration : ConfigurationBase<ProductServiceType>
    {
        private EntityTypeBuilder<ProductServiceType> entityTypeBuilder;

        public ProductServiceTypeConfiguration(EntityTypeBuilder<ProductServiceType> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<ProductServiceType> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<ProductServiceType> builder)
        {
            builder.HasIndex(e => new { e.ServiceTypeId, e.ProductId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<ProductServiceType> builder)
        {
            builder.HasKey(e => e.ProductServiceTypeId);
            builder.Property(e => e.ServiceTypeId).IsRequired();
            builder.Property(e => e.ProductId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<ProductServiceType> builder)
        {
            builder.HasOne(e => e.Product)
                 .WithMany(e => e.ProductServiceTypes)
                 .HasForeignKey(e => e.ProductId)
                .HasConstraintName("FK_Product_ProductServiceTypeId").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.ServiceType)
               .WithMany(e => e.ProductServiceTypes)
               .HasForeignKey(e => e.ServiceTypeId)
               .HasConstraintName("FK_ServiceType_ProductServiceTypeId").OnDelete(DeleteBehavior.Restrict);
        }
    }
}