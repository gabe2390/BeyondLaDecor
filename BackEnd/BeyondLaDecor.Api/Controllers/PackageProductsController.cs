using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class PackageProductsController : BaseController<PackageProduct, PackageProductModel>
    {
        public PackageProductsController(IMapper mapper, IPackageProductLogic packageProductLogic) : base(mapper, packageProductLogic)
        {
        }
    }
}