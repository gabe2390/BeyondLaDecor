using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class EventTypesController : BaseController<EventType, EventTypeModel>
    {
        public EventTypesController(IMapper mapper, IEventTypeLogic eventTypeLogic) : base(mapper, eventTypeLogic)
        {
        }
    }
}