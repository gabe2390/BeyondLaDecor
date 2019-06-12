using BeyondLaDecor.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    internal class ClientConfiguration : ConfigurationBase<Client>
    {
        private EntityTypeBuilder<Client> entityTypeBuilder;

        public ClientConfiguration(EntityTypeBuilder<Client> entityTypeBuilder) : base(entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public override void ConfigureFilter(EntityTypeBuilder<Client> builder)
        {
        }

        public override void ConfigureIndexes(EntityTypeBuilder<Client> builder)
        {
            builder.HasIndex(e => new { e.Email });
        }

        public override void ConfigureProperties(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.ClientId);
            builder.Property(e => e.FirstName).IsRequired();
            builder.Property(e => e.LastName).IsRequired();
            builder.Property(e => e.Address).IsRequired();
            builder.Property(e => e.City).IsRequired();
            builder.Property(e => e.State).IsRequired();
            builder.Property(e => e.ZipCode).IsRequired();
            builder.Property(e => e.Email).IsRequired();
        }

        public override void ConfigureRelationships(EntityTypeBuilder<Client> builder)
        {
            builder.HasMany(e => e.Events)
                .WithOne(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .HasConstraintName("FK_Client_Event");
        }
    }
}