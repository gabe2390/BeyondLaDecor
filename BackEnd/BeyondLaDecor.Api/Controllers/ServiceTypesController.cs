using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ServiceTypesController : BaseController<ServiceType>
    {
        public ServiceTypesController(IServiceTypeLogic serviceTypeLogic) : base(serviceTypeLogic)
        {
        }
    }
}