using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class ProductTypeConfiguration : ConfigurationBase<ProductType>
    {
        private EntityTypeBuilder<ProductType> entityTypeBuilder;

        public ProductTypeConfiguration(EntityTypeBuilder<ProductType> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<ProductType> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasIndex(e => e.Name);
        }

        public override void ConfigureProperties(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(e => e.ProductTypeId);
            builder.Property(e => e.Name).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasMany(e => e.Products)
                .WithOne(e => e.ProductType)
                .HasForeignKey(e => e.ProductTypeId)
                .HasConstraintName("FK_Product_ProductType").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Administrator)
              .WithMany(e => e.ProductTypes)
              .HasForeignKey(e => e.AdministratorId)
              .HasConstraintName("FK_Administrator_ProductType")
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}