using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class PackageServiceConfiguration : ConfigurationBase<PackageService>
    {
        private EntityTypeBuilder<PackageService> entityTypeBuilder;

        public PackageServiceConfiguration(EntityTypeBuilder<PackageService> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<PackageService> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<PackageService> builder)
        {
            builder.HasIndex(e => new { e.PackageId, e.ServiceId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<PackageService> builder)
        {
            builder.HasKey(e => e.PackageServiceId);
            builder.Property(e => e.PackageId).IsRequired();
            builder.Property(e => e.ServiceId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<PackageService> builder)
        {
            builder.HasOne(e => e.Package)
                 .WithMany(e => e.PackageServices)
                 .HasForeignKey(e => e.PackageId)
                 .HasConstraintName("FK_Package_PackageService").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Service)
               .WithMany(e => e.PackageServices)
               .HasForeignKey(e => e.ServiceId)
               .HasConstraintName("FK_Service_PackageService").OnDelete(DeleteBehavior.Restrict);
        }
    }
}