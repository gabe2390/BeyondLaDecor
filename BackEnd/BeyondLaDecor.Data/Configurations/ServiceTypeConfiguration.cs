using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class ServiceTypeConfiguration : ConfigurationBase<ServiceType>
    {
        private EntityTypeBuilder<ServiceType> entityTypeBuilder;

        public ServiceTypeConfiguration(EntityTypeBuilder<ServiceType> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<ServiceType> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<ServiceType> builder)
        {
            builder.HasIndex(e => e.Name);
        }

        public override void ConfigureProperties(EntityTypeBuilder<ServiceType> builder)
        {
            builder.HasKey(e => e.ServiceTypeId);
            builder.Property(e => e.Name).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<ServiceType> builder)
        {
            builder.HasMany(e => e.Services)
                 .WithOne(e => e.ServiceType)
                 .HasForeignKey(e => e.ServiceTypeId)
                 .HasConstraintName("FK_Service_ServiceType").OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Vendors)
               .WithOne(e => e.ServiceType)
               .HasForeignKey(e => e.ServiceTypeId)
               .HasConstraintName("FK_Vendor_ServiceType").OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Products)
                .WithOne(e => e.ServiceType)
                .HasForeignKey(e => e.ServiceTypeId)
                .HasConstraintName("FK_Product_ServiceType").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.ParentServiceType)
                .WithMany(e => e.ChildServiceTypes)
                .HasForeignKey(e => e.ParentServiceTypeId)
                .HasConstraintName("FK_Parent_ServiceType").OnDelete(DeleteBehavior.Restrict);

        }
    }
}