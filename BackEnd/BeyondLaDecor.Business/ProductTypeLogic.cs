using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IProductTypeLogic : IBusinessLogicBase<ProductType>
    {
    }
    public class ProductTypeLogic : BusinessLogicBase<ProductType>, IProductTypeLogic
    {
        public ProductTypeLogic(IProductTypeRepository repository) : base(repository)
        {
        }
    }
}