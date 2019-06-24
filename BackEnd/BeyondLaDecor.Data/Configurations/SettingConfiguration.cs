using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class SettingConfiguration : ConfigurationBase<Setting>
    {
        private EntityTypeBuilder<Setting> entityTypeBuilder;

        public SettingConfiguration(EntityTypeBuilder<Setting> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Setting> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Setting> builder)
        {
            builder.HasIndex(e => new { e.Name });
        }

        public override void ConfigureProperties(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(e => e.SettingId);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.SettingType).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Setting> builder)
        {
            builder.HasMany(e => e.UserSettings)
                .WithOne(e => e.Setting)
                .HasForeignKey(e => e.SettingId)
                .HasConstraintName("FK_UserSetting_Setting")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}