using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ProductServiceTypesController : BaseController<ProductServiceType, ProductServiceTypeModel>
    {
        public ProductServiceTypesController(IMapper mapper, IProductServiceTypeLogic productServiceTypeLogic) : base(mapper, productServiceTypeLogic)
        {
        }
    }
}