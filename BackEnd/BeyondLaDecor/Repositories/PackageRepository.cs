using BeyondLaDecor.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IPackageRepository : IBaseModelRepository<Package>
    {
    }
    public class PackageRepository : BaseModelRepository<Package>, IPackageRepository
    {
        public PackageRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
