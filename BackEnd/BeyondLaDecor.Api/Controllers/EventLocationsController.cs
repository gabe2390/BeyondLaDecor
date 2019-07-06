using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class EventLocationsController : BaseController<EventLocation>
    {
        public EventLocationsController(IEventLocationLogic eventLocationLogic) : base(eventLocationLogic)
        {
        }
    }
}