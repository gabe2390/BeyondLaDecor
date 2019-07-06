using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class EventsController : BaseController<Event>
    {
        public EventsController(IEventLogic eventLogic) : base(eventLogic)
        {
        }
    }
}