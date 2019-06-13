using BeyondLaDecor.Beyond.Data.Configurations;
using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class ServiceConfiguration : ConfigurationBase<Service>
    {
        private EntityTypeBuilder<Service> entityTypeBuilder;

        public ServiceConfiguration(EntityTypeBuilder<Service> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Service> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Service> builder)
        {
            builder.HasIndex(e => new { e.ServiceTypeId, e.Name });
        }

        public override void ConfigureProperties(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(e => e.ServiceId);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.ServiceTypeId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Service> builder)
        {
            builder.HasMany(e => e.PackageServices)
                .WithOne(e => e.Service)
                .HasForeignKey(e => e.ServiceId)
                .HasConstraintName("FK_Package_PackageService");
            builder.HasMany(e => e.Vendors)
                .WithOne(e => e.Service)
                .HasForeignKey(e => e.ServiceId)
                .HasConstraintName("FK_Service_Vendor");
            builder.HasOne(e => e.ServiceType)
                .WithMany(e => e.Services)
                .HasForeignKey(e => e.ServiceId)
                .HasConstraintName("FK_Service_ServiceType");
        }
    }
}