using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ServicesController : BaseController<Service>
    {
        public ServicesController(IServiceLogic serviceLogic) : base(serviceLogic)
        {
        }
    }
}