using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class VendorsController : BaseController<Vendor>
    {
        public VendorsController(IVendorLogic vendorLogic) : base(vendorLogic)
        {
        }
    }
}