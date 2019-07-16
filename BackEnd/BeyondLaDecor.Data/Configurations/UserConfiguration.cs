using BeyondLaDecor.Beyond.Data.Models;
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
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseSqlServerIdentityColumn();
            builder.Property(e => e.FirstName).IsRequired();
            builder.Property(e => e.LastName).IsRequired();
            builder.Property(e => e.City).IsRequired();
            builder.Property(e => e.State).IsRequired();
            builder.Property(e => e.ZipCode).IsRequired();
            builder.Property(e => e.Email).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(e => e.ClientEvents)
                .WithOne(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .HasConstraintName("FK_Client_Event")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.AdministratorEvents)
               .WithOne(e => e.Administrator)
               .HasForeignKey(e => e.AdministratorId)
               .HasConstraintName("FK_Administrator_Event")
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Clients)
                .WithOne(e => e.Administrator)
                .HasForeignKey(e => e.AdministratorId)
                .HasConstraintName("FK_Admin_Client")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Administrator)
                .WithMany(e => e.Clients)
                .HasForeignKey(e => e.AdministratorId)
                .HasConstraintName("FK_Client_Admin")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.UserSettings)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .HasConstraintName("FK_UserSetting_User")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.UserSettings)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .HasConstraintName("FK_Client_UserSetting")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.EventTypes)
                .WithOne(e => e.Administrator)
                .HasForeignKey(e => e.AdministratorId)
                .HasConstraintName("FK_Administrator_EventType")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Products)
               .WithOne(e => e.Administrator)
               .HasForeignKey(e => e.AdministratorId)
               .HasConstraintName("FK_Product_Administrator")
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.ProductTypes)
               .WithOne(e => e.Administrator)
               .HasForeignKey(e => e.AdministratorId)
               .HasConstraintName("FK_Administrator_ProductType")
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Services)
                .WithOne(e => e.Administrator)
                .HasForeignKey(e => e.AdministratorId)
                .HasConstraintName("FK_Administrator_Service")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.ServiceTypes)
                 .WithOne(e => e.Administrator)
                 .HasForeignKey(e => e.AdministratorId)
                 .HasConstraintName("FK_Administrator_ServiceType ")
                 .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Vendors)
                .WithOne(e => e.Administrator)
                .HasForeignKey(e => e.AdministratorId)
                .HasConstraintName("FK_Administrator_Vendor")
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.Packages)
               .WithOne(e => e.Administrator)
               .HasForeignKey(e => e.AdministratorId)
               .HasConstraintName("FK_Package_Administrator")
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}