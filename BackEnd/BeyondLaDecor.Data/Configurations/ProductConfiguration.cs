using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class ProductConfiguration : ConfigurationBase<Product>
    {
        private EntityTypeBuilder<Product> entityTypeBuilder;

        public ProductConfiguration(EntityTypeBuilder<Product> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Product> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(e => new { e.Name, e.ProductTypeId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.ProductId);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.ProductTypeId).IsRequired();
            builder.Property(e => e.Description).IsRequired();
            builder.Property(e => e.Price).IsRequired();
            builder.Property(e => e.ThirdParty).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(e => e.PackageProducts)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .HasConstraintName("FK_Product_PackageProduct").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.ProductType)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.ProductTypeId)
                .HasConstraintName("FK_Product_ProductType").OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.ProductServiceTypes)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .HasConstraintName("FK_Product_ServiceType").OnDelete(DeleteBehavior.Restrict);
        }
    }
}