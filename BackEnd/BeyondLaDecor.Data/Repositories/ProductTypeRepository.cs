using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IProductTypeRepository : IBaseModelRepository<ProductType>
    {
    }
    public class ProductTypeRepository : BaseModelRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
