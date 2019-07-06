using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IProductServiceTypeRepository : IBaseModelRepository<ProductServiceType>
    {
    }
    public class ProductServiceTypeRepository : BaseModelRepository<ProductServiceType>, IProductServiceTypeRepository
    {
        public ProductServiceTypeRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
