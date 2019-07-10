using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class PackagesController : BaseController<Package>
    {
        private IPackageLogic PackageLogic { get; set; }
        public PackagesController(IPackageLogic packageLogic) : base(packageLogic)
        {
            PackageLogic = packageLogic;
        }
        
        [HttpGet("[controller]/{packageId}/Services")]
        public IEnumerable<Service> ServicesByPackage(int packageId)
        {
            return PackageLogic.GetServicesByPackage(packageId);
        }
    }
}