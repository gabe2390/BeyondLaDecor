using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class PackageServicesController : BaseController<PackageService, PackageServiceModel>
    {
        public PackageServicesController(IMapper mapper, IPackageServiceLogic packageServiceLogic) : base(mapper, packageServiceLogic)
        {
        }
    }
}