using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IProductRepository : IBaseModelRepository<Product>
    {
    }
    public class ProductRepository : BaseModelRepository<Product>, IProductRepository
    {
        public ProductRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
