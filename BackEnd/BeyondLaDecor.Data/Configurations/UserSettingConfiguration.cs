using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class UserSettingConfiguration : ConfigurationBase<UserSetting>
    {
        private EntityTypeBuilder<UserSetting> entityTypeBuilder;

        public UserSettingConfiguration(EntityTypeBuilder<UserSetting> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<UserSetting> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<UserSetting> builder)
        {
            builder.HasIndex(e => new { e.UserId, e.SettingId });
        }

        public override void ConfigureProperties(EntityTypeBuilder<UserSetting> builder)
        {
            builder.HasKey(e => e.UserSettingId);
            builder.Property(e => e.Enabled).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<UserSetting> builder)
        {
            builder.HasOne(e => e.User)
                .WithMany(e => e.UserSettings)
                .HasForeignKey(e => e.UserId)
                .HasConstraintName("FK_UserSetting_User")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Setting)
                .WithMany(e => e.UserSettings)
                .HasForeignKey(e => e.SettingId)
                .HasConstraintName("FK_UserSetting_Setting")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Client)
              .WithMany(e => e.ClientSpecificUserSettings)
              .HasForeignKey(e => e.ClientId)
              .HasConstraintName("FK_Client_UserSetting")
              .OnDelete(DeleteBehavior.Restrict);

        }
    }
}