using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class InventoryRecordConfiguration : ConfigurationBase<InventoryRecord>
    {
        private EntityTypeBuilder<InventoryRecord> entityTypeBuilder;

        public InventoryRecordConfiguration(EntityTypeBuilder<InventoryRecord> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<InventoryRecord> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<InventoryRecord> builder)
        {
            builder.HasIndex(e => new { e.InventoryId, e.ProductId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<InventoryRecord> builder)
        {
            builder.HasKey(e => e.InventoryRecordId);
            builder.Property(e => e.InventoryRecordId).UseSqlServerIdentityColumn();
            builder.Property(e => e.ProductId).IsRequired();
            builder.Property(e => e.InventoryId).IsRequired();
            builder.Property(e => e.Quantity).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<InventoryRecord> builder)
        {
            builder.HasOne(e => e.Product)
                .WithOne(e => e.InventoryRecord)
                .HasForeignKey<InventoryRecord>(e => e.ProductId)
                .HasConstraintName("FK_InventoryRecord_Product")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Inventory)
              .WithMany(e => e.InventoryRecords)
              .HasForeignKey(e => e.InventoryId)
              .HasConstraintName("FK_InventoryRecord_Inventory")
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}