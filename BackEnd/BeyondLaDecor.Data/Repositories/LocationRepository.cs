using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface ILocationRepository : IBaseModelRepository<Location>
    {
    }
    public class LocationRepository : BaseModelRepository<Location>, ILocationRepository
    {
        public LocationRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
