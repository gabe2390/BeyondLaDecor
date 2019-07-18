using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ServiceVendorsController : BaseController<ServiceVendor, ServiceVendorModel>
    {
        public ServiceVendorsController(IMapper mapper, IServiceVendorLogic serviceVendorLogic) : base(mapper, serviceVendorLogic)
        {
        }
    }
}