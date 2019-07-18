using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class EventLocationsController : BaseController<EventLocation, EventLocationModel>
    {
        public EventLocationsController(IMapper mapper, IEventLocationLogic eventLocationLogic) : base(mapper, eventLocationLogic)
        {
        }
    }
}