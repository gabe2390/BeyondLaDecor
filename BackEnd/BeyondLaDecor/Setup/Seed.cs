using System;
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

        private void SeedDefaultProducts(BeyondDbContext context)
        {
            throw new NotImplementedException();
        }

        private void SeedDefaultServices(BeyondDbContext context)
        {
            throw new NotImplementedException();
        }

        private void SeedDefaultEventTypes(BeyondDbContext context)
        {
            throw new NotImplementedException();
        }

        private void SeedDefaultProductTypes(BeyondDbContext context)
        {
            throw new NotImplementedException();
        }

        private void SeedDefaultServiceTypes(BeyondDbContext context)
        {
        }
    }
}
