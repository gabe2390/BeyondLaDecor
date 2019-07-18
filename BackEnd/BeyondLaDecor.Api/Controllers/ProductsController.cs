using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ProductsController : BaseController<Product, ProductModel>
    {
        public ProductsController(IMapper mapper, IProductLogic productLogic) : base(mapper, productLogic)
        {
        }
    }
}