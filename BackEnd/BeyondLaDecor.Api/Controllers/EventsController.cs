using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class EventsController : BaseController<Event>
    {
        public EventsController(IEventLogic eventLogic) : base(eventLogic)
        {
        }
    }
}