using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    public interface IConfigurationBase<T> where T : class, new()
    {
        void Configure();
        void ConfigureFilter(EntityTypeBuilder<T> builder);
        void ConfigureRelationships(EntityTypeBuilder<T> builder);
        void ConfigureProperties(EntityTypeBuilder<T> builder);
        void ConfigureIndexes(EntityTypeBuilder<T> builder);
        void CreateTable(EntityTypeBuilder<T> builder);
    }
}
