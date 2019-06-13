using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class ServiceTypesController : BaseController<ServiceType>
    {
        public ServiceTypesController(IServiceTypeLogic serviceTypeLogic) : base(serviceTypeLogic)
        {
        }
    }
}