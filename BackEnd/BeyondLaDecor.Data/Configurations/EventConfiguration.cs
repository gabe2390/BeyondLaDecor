using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class EventConfiguration : ConfigurationBase<Event>
    {
        private EntityTypeBuilder<Event> entityTypeBuilder;

        public EventConfiguration(EntityTypeBuilder<Event> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Event> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Event> builder)
        {
            builder.HasIndex(e => new { e.PackageId, e.EventTypeId, e.UserId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.EventId);
            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.Address).IsRequired();
            builder.Property(e => e.Capacity).IsRequired();
            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.EventTypeId).IsRequired();
            builder.Property(e => e.PackageId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Event> builder)
        {
            builder.HasOne(e => e.EventType)
                .WithMany(e => e.Events)
                .HasForeignKey(e => e.EventTypeId)
                .HasConstraintName("FK_Event_EventType")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Tasks)
              .WithOne(e => e.Event)
              .HasForeignKey(e => e.EventId)
              .HasConstraintName("FK_Event_Task")
              .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Package)
                .WithMany(e => e.Events)
                .HasForeignKey(e => e.PackageId)
                .HasConstraintName("FK_Event_Package")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User)
                .WithMany(e => e.Events)
                .HasForeignKey(e => e.UserId)
                .HasConstraintName("FK_User_Event")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}