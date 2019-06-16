using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class UserConfiguration : ConfigurationBase<User>
    {
        private EntityTypeBuilder<User> entityTypeBuilder;

        public UserConfiguration(EntityTypeBuilder<User> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<User> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(e => new { e.Email });
        }

        public override void ConfigureProperties(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.FirstName).IsRequired();
            builder.Property(e => e.LastName).IsRequired();
            builder.Property(e => e.Address).IsRequired();
            builder.Property(e => e.City).IsRequired();
            builder.Property(e => e.State).IsRequired();
            builder.Property(e => e.ZipCode).IsRequired();
            builder.Property(e => e.Email).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(e => e.Events)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .HasConstraintName("FK_User_Event").OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Clients)
                .WithOne(e => e.Administrator)
                .HasForeignKey(e => e.AdminstratorId)
                .HasConstraintName("FK_Admin_Client").OnDelete(DeleteBehavior.Restrict);
        }
    }
}