using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IEventTypeRepository : IBaseModelRepository<EventType>
    {
    }
    public class EventTypeRepository : BaseModelRepository<EventType>, IEventTypeRepository
    {
        public EventTypeRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
