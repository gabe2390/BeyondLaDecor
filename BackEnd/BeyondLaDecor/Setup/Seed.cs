using BeyondLaDecor.Beyond.Data;

namespace BeyondLaDecor.Data.Setup
{
    public class Seed
    {
        public void SeedData(BeyondDbContext context)
        {
            SeedDefaultServiceTypes(context);
            SeedDefaultProductTypes(context);
            SeedDefaultEventTypes(context);
            SeedDefaultServices(context);
            SeedDefaultProducts(context);
        }

        private void SeedDefaultServiceTypes(BeyondDbContext context)
        {
            context.
        }
    }
}
