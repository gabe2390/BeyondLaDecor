using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class VendorTypesController : BaseController<VendorType>
    {
        public VendorTypesController(IVendorTypeLogic vendorTypeLogic) : base(vendorTypeLogic)
        {
        }
    }
}