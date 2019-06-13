using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class ServicesController : BaseController<Service>
    {
        public ServicesController(IServiceLogic serviceLogic) : base(serviceLogic)
        {
        }
    }
}