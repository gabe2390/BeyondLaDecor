using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class PackagesController : BaseController<Package>
    {
        public PackagesController(IPackageLogic packageLogic) : base(packageLogic)
        {
        }
    }
}