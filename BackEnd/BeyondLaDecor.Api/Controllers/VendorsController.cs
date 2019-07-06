using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class VendorsController : BaseController<Vendor>
    {
        public VendorsController(IVendorLogic vendorLogic) : base(vendorLogic)
        {
        }
    }
}