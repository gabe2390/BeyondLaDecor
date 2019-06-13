using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IEventTypeLogic : IBusinessLogicBase<EventType>
    {
    }
    public class EventTypeLogic : BusinessLogicBase<EventType>, IEventTypeLogic
    {
        protected EventTypeLogic(IEventTypeRepository repository) : base(repository)
        {
        }
    }
}