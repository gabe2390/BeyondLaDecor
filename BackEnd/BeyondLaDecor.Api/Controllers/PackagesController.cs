using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class PackagesController : BaseController<Package, PackageModel>
    {
        private IPackageLogic PackageLogic { get; set; }
        public PackagesController(IMapper mapper, IPackageLogic packageLogic) : base(mapper, packageLogic)
        {
            PackageLogic = packageLogic;
        }

        [HttpGet("[controller]/{packageId}/Detail")]
        public PackageModel GetDetailedPackage(int packageId)
        {
            return Mapper.Map<PackageModel>(PackageLogic.PackageDetail(packageId));
        }

        [HttpGet("[controller]/{packageId}/Services")]
        public IEnumerable<ServiceModel> ServicesByPackage(int packageId)
        {
            return PackageLogic.GetServicesByPackage (packageId).Select(Mapper.Map<ServiceModel>);
        }
    }
}