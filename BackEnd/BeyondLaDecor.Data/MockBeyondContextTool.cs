using Microsoft.EntityFrameworkCore;

namespace BeyondLaDecor.Beyond.Data
{
    public class MockBeyondContextTool
    {
        public string ConnectionString { get; set; }

        public BeyondDbContext GetDbProviderContext()
        {
            var contextBuilder = new DbContextOptionsBuilder<BeyondDbContext>();
            contextBuilder.UseSqlServer(this.ConnectionString);
            return new BeyondDbContext(contextBuilder.Options);
        }
    }
}
