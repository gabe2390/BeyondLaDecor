using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class TaskConfiguration : ConfigurationBase<Task>
    {
        private EntityTypeBuilder<Task> entityTypeBuilder;

        public TaskConfiguration(EntityTypeBuilder<Task> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Task> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Task> builder)
        {
            builder.HasIndex(e => new { e.Name, e.ServiceId, e.EventId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(e => e.TaskId);
            builder.Property(e => e.Name).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Task> builder)
        {
            builder.HasOne(e => e.Service)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.ServiceId)
                .HasConstraintName("FK_Service_Task")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Event)
              .WithMany(e => e.Tasks)
              .HasForeignKey(e => e.EventId)
              .HasConstraintName("FK_Event_Task")
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}