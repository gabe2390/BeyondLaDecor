using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class EventTypesController : BaseController<EventType>
    {
        public EventTypesController(IEventTypeLogic eventTypeLogic) : base(eventTypeLogic)
        {
        }
    }
}