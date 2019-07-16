using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IEventLocationRepository : IBaseModelRepository<EventLocation>
    {
    }
    public class EventLocationRepository : BaseModelRepository<EventLocation>, IEventLocationRepository
    {
        public EventLocationRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
