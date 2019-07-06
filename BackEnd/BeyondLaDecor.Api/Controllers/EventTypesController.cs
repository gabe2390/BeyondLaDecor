using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class EventTypesController : BaseController<EventType>
    {
        public EventTypesController(IEventTypeLogic eventTypeLogic) : base(eventTypeLogic)
        {
        }
    }
}