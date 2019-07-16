using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class InventoryConfiguration : ConfigurationBase<Inventory>
    {
        private EntityTypeBuilder<Inventory> entityTypeBuilder;

        public InventoryConfiguration(EntityTypeBuilder<Inventory> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Inventory> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasIndex(e => new { e.InventoryId, e.AdministratorId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(e => e.InventoryId);
            builder.Property(e => e.InventoryId).UseSqlServerIdentityColumn();
            builder.Property(e => e.AdministratorId).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasOne(e => e.Administrator)
                .WithOne(e => e.Inventory)
                .HasForeignKey<Inventory>(e => e.AdministratorId)
                .HasConstraintName("FK_Inventory_User")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.InventoryRecords)
              .WithOne(e => e.Inventory)
              .HasForeignKey(e => e.InventoryId)
              .HasConstraintName("FK_Inventory_InventoryRecord")
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}