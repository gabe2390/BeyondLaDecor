using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class LocationsController : BaseController<Location, LocationModel>
    {
        public LocationsController(IMapper mapper, ILocationLogic locationLogic) : base(mapper, locationLogic)
        {
        }
    }
}