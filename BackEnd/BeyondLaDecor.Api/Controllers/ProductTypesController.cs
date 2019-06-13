using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class ProductTypesController : BaseController<ProductType>
    {
        public ProductTypesController(IProductTypeLogic productTypeLogic) : base(productTypeLogic)
        {
        }
    }
}