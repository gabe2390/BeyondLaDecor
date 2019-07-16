using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IProductServiceTypeLogic : IBusinessLogicBase<ProductServiceType>
    {
    }
    public class ProductServiceTypeLogic : BusinessLogicBase<ProductServiceType>, IProductServiceTypeLogic
    {
        public ProductServiceTypeLogic(IProductServiceTypeRepository repository) : base(repository)
        {
        }
    }
}