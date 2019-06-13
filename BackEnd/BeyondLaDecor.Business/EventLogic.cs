using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IEventLogic : IBusinessLogicBase<Event>
    {
    }
    public class EventLogic : BusinessLogicBase<Event>, IEventLogic
    {
        protected EventLogic(IEventRepository repository) : base(repository)
        {
        }
    }
}