using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class PackageProductsController : BaseController<PackageProduct>
    {
        public PackageProductsController(IPackageProductLogic packageProductLogic) : base(packageProductLogic)
        {
        }
    }
}