using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class PackageConfiguration : ConfigurationBase<Package>
    {
        private EntityTypeBuilder<Package> entityTypeBuilder;

        public PackageConfiguration(EntityTypeBuilder<Package> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Package> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Package> builder)
        {
            builder.HasIndex(e => e.Name);
        }

        public override void ConfigureProperties(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(e => e.PackageId);
            builder.Property(e => e.Name).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Package> builder)
        {
            builder.HasMany(e => e.Events)
                .WithOne(e => e.Package)
                .HasForeignKey(e => e.PackageId)
                .HasConstraintName("FK_Package_Event");
            builder.HasMany(e => e.PackageProducts)
                .WithOne(e => e.Package)
                .HasForeignKey(e => e.PackageId)
                .HasConstraintName("FK_Package_PackageProduct");
            builder.HasMany(e => e.PackageServices)
                .WithOne(e => e.Package)
                .HasForeignKey(e => e.PackageId)
                .HasConstraintName("FK_Package_PackageService");
        }
    }
}