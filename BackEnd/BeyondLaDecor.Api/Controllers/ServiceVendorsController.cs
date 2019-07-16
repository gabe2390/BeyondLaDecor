using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ServiceVendorsController : BaseController<ServiceVendor>
    {
        public ServiceVendorsController(IServiceVendorLogic ServiceVendorLogic) : base(ServiceVendorLogic)
        {
        }
    }
}