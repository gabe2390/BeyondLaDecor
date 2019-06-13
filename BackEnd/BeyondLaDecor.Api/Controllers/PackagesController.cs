using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class PackagesController : BaseController<Package>
    {
        public PackagesController(IPackageLogic packageLogic) : base(packageLogic)
        {
        }
    }
}