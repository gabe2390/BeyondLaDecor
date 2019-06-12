using Microsoft.EntityFrameworkCore;
using BeyondLaDecor.Data.Setup;

namespace BeyondLaDecor.Beyond.Data
{
    public class Program
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=BeyondLaDecor;";
        public static void Main(string[] args)
        {
            var mockDocManagementContextTool = new MockBeyondContextTool()
            {
                ConnectionString = ConnectionString
            };

            using (var context = mockDocManagementContextTool.GetDbProviderContext())
            {
                context.Database.Migrate();
                var seed = new Seed();
                seed.SeedData(context);
            }
        }
    }
}
