using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ProductTypesController : BaseController<ProductType>
    {
        public ProductTypesController(IProductTypeLogic productTypeLogic) : base(productTypeLogic)
        {
        }
    }
}