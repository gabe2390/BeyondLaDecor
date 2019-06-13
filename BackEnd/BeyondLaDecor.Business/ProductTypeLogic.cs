using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IProductTypeLogic : IBusinessLogicBase<ProductType>
    {
    }
    public class ProductTypeLogic : BusinessLogicBase<ProductType>, IProductTypeLogic
    {
        protected ProductTypeLogic(IProductTypeRepository repository) : base(repository)
        {
        }
    }
}