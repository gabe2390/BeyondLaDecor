using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class PackageServicesController : BaseController<PackageService>
    {
        public PackageServicesController(IPackageServiceLogic packageServiceLogic) : base(packageServiceLogic)
        {
        }
    }
}