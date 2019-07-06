using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class PackageProductsController : BaseController<PackageProduct>
    {
        public PackageProductsController(IPackageProductLogic packageProductLogic) : base(packageProductLogic)
        {
        }
    }
}