using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class ProductsController : BaseController<Product>
    {
        public ProductsController(IProductLogic productLogic) : base(productLogic)
        {
        }
    }
}