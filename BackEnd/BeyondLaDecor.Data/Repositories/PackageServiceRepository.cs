using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IPackageServiceRepository : IBaseModelRepository<PackageService>
    {
    }
    public class PackageServiceRepository : BaseModelRepository<PackageService>, IPackageServiceRepository
    {
        public PackageServiceRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
