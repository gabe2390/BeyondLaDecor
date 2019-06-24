using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeyondLaDecor.Beyond.Data.Configurations
{
    public abstract class ConfigurationBase<T> : IConfigurationBase<T> where T : class, new()
    {
        protected ConfigurationBase(EntityTypeBuilder<T> builder)
        {
            Builder = builder;
        }
        internal EntityTypeBuilder<T> Builder { get; set; }
        public void Configure()
        {
            CreateTable(Builder);
            ConfigureIndexes(Builder);
            ConfigureProperties(Builder);
            ConfigureRelationships(Builder);
            ConfigureFilter(Builder);
        }
        public abstract void ConfigureFilter(EntityTypeBuilder<T> builder);
        public abstract void ConfigureIndexes(EntityTypeBuilder<T> builder);
        public abstract void ConfigureProperties(EntityTypeBuilder<T> builder);
        public abstract void ConfigureRelationships(EntityTypeBuilder<T> builder);
        private void CreateTable(EntityTypeBuilder<T> builder) { builder.ToTable(typeof(T).Name); }
    }
}
