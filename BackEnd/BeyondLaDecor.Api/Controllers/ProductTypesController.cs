using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ProductTypesController : BaseController<ProductType, ProductTypeModel>
    {
        public ProductTypesController(IMapper mapper, IProductTypeLogic productTypeLogic) : base(mapper, productTypeLogic)
        {
        }
    }
}