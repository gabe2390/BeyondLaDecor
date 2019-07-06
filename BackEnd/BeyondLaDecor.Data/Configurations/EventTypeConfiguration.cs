using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class EventTypeConfiguration : ConfigurationBase<EventType>
    {
        private EntityTypeBuilder<EventType> entityTypeBuilder;

        public EventTypeConfiguration(EntityTypeBuilder<EventType> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<EventType> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<EventType> builder)
        {
            builder.HasIndex(e => new { e.EventTypeId, e.Name });
        }

        public override void ConfigureProperties(EntityTypeBuilder<EventType> builder)
        {
            builder.HasKey(e => e.EventTypeId);
            builder.Property(e => e.Name).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<EventType> builder)
        {
            builder.HasMany(e => e.Events)
                .WithOne(e => e.EventType)
                .HasForeignKey(e => e.EventTypeId)
                .HasConstraintName("FK_Event_EventType").OnDelete(DeleteBehavior.Restrict);
        }
    }
}