using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class PackageServicesController : BaseController<PackageService>
    {
        public PackageServicesController(IPackageServiceLogic packageServiceLogic) : base(packageServiceLogic)
        {
        }
    }
}