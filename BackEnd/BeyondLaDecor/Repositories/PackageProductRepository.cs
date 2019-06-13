using BeyondLaDecor.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IPackageProductRepository : IBaseModelRepository<PackageProduct>
    {
    }
    public class PackageProductRepository : BaseModelRepository<PackageProduct>, IPackageProductRepository
    {
        public PackageProductRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
