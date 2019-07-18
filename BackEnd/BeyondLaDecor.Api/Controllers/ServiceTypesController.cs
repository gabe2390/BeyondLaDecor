using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ServiceTypesController : BaseController<ServiceType, ServiceTypeModel>
    {
        public ServiceTypesController(IMapper mapper, IServiceTypeLogic serviceTypeLogic) : base(mapper, serviceTypeLogic)
        {
        }
    }
}