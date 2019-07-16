using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ProductServiceTypesController : BaseController<ProductServiceType>
    {
        public ProductServiceTypesController(IProductServiceTypeLogic ProductServiceTypeLogic) : base(ProductServiceTypeLogic)
        {
        }
    }
}