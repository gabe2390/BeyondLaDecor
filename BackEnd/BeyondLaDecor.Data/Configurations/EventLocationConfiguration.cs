using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class EventLocationConfiguration : ConfigurationBase<EventLocation>
    {
        private EntityTypeBuilder<EventLocation> entityTypeBuilder;

        public EventLocationConfiguration(EntityTypeBuilder<EventLocation> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<EventLocation> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<EventLocation> builder)
        {
            builder.HasIndex(e => new { e.EventId, e.LocationId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<EventLocation> builder)
        {
            builder.HasKey(e => e.EventLocationId);
            builder.Property(e => e.EventId).IsRequired();
            builder.Property(e => e.LocationId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<EventLocation> builder)
        {
            builder.HasOne(e => e.Event)
                 .WithMany(e => e.EventLocations)
                 .HasForeignKey(e => e.EventId)
                 .HasConstraintName("FK_EventLocation_Event")
                 .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Location)
               .WithMany(e => e.EventLocations)
               .HasForeignKey(e => e.LocationId)
               .HasConstraintName("FK_EventLocation_Location")
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}