using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class EventsController : BaseController<Event, EventModel>
    {
        public EventsController(IMapper mapper, IEventLogic eventLogic) : base(mapper, eventLogic)
        {
        }
    }
}