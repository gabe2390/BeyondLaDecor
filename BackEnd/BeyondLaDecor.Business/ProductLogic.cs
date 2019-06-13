using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IProductLogic : IBusinessLogicBase<Product>
    {
    }
    public class ProductLogic : BusinessLogicBase<Product>, IProductLogic
    {
        protected ProductLogic(IProductRepository repository) : base(repository)
        {
        }
    }
}