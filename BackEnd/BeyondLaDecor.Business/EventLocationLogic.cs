using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IEventLocationLogic : IBusinessLogicBase<EventLocation>
    {
    }
    public class EventLocationLogic : BusinessLogicBase<EventLocation>, IEventLocationLogic
    {
        public EventLocationLogic(IEventLocationRepository repository) : base(repository)
        {
        }
    }
}