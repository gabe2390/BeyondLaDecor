using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IProductLogic : IBusinessLogicBase<Product>
    {
    }
    public class ProductLogic : BusinessLogicBase<Product>, IProductLogic
    {
        public ProductLogic(IProductRepository repository) : base(repository)
        {
        }
    }
}