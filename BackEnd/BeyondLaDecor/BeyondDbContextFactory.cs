using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BeyondLaDecor.Beyond.Data
{
    /// <summary>
    /// </summary>
    public class BeyondDbContextFactory : IDesignTimeDbContextFactory<BeyondDbContext>
    {
        private string ConnectionString { get; set; }

        public BeyondDbContextFactory()
        {
        }
        public BeyondDbContextFactory(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public BeyondDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BeyondDbContext>();
            builder.UseSqlServer(ConnectionString ?? "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BeyondLaDecor;");
            return new BeyondDbContext(builder.Options);
        }
    }
}

