using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class VendorsController : BaseController<Vendor, VendorModel>
    {
        public VendorsController(IMapper mapper, IVendorLogic vendorLogic) : base(mapper, vendorLogic)
        {
        }
    }
}