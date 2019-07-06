using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IEventTypeLogic : IBusinessLogicBase<EventType>
    {
    }
    public class EventTypeLogic : BusinessLogicBase<EventType>, IEventTypeLogic
    {
        public EventTypeLogic(IEventTypeRepository repository) : base(repository)
        {
        }
    }
}