using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IEventLogic : IBusinessLogicBase<Event>
    {
    }
    public class EventLogic : BusinessLogicBase<Event>, IEventLogic
    {
        public EventLogic(IEventRepository repository) : base(repository)
        {
        }
    }
}