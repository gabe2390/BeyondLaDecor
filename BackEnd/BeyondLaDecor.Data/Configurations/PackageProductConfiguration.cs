using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class PackageProductConfiguration : ConfigurationBase<PackageProduct>
    {
        private EntityTypeBuilder<PackageProduct> entityTypeBuilder;

        public PackageProductConfiguration(EntityTypeBuilder<PackageProduct> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<PackageProduct> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<PackageProduct> builder)
        {
            builder.HasIndex(e => new { e.PackageId, e.ProductId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<PackageProduct> builder)
        {
            builder.HasKey(e => e.PackageProductId);
            builder.Property(e => e.PackageId).IsRequired();
            builder.Property(e => e.ProductId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<PackageProduct> builder)
        {
            builder.HasOne(e => e.Package)
                 .WithMany(e => e.PackageProducts)
                 .HasForeignKey(e => e.PackageId)
                 .HasConstraintName("FK_Package_PackageProduct").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Product)
               .WithMany(e => e.PackageProducts)
               .HasForeignKey(e => e.ProductId)
               .HasConstraintName("FK_Product_PackageProduct").OnDelete(DeleteBehavior.Restrict);
        }
    }
}