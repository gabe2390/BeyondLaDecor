using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class LocationConfiguration : ConfigurationBase<Location>
    {
        private EntityTypeBuilder<Location> entityTypeBuilder;

        public LocationConfiguration(EntityTypeBuilder<Location> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Location> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Location> builder)
        {
            builder.HasIndex(e => e.Name);
        }

        public override void ConfigureProperties(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(e => e.LocationId);
            builder.Property(e => e.LocationId).UseSqlServerIdentityColumn();
            builder.Property(e => e.Address).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.City).IsRequired();
            builder.Property(e => e.State).IsRequired();
            builder.Property(e => e.ZipCode).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Location> builder)
        {
            builder.HasMany(e => e.EventLocations)
                .WithOne(e => e.Location)
                .HasForeignKey(e => e.LocationId)
                .HasConstraintName("FK_EventLocation_Location")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Vendor)
                .WithMany(e => e.Locations)
                .HasForeignKey(e => e.VendorId)
                .HasConstraintName("FK_Location_Vendor")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}