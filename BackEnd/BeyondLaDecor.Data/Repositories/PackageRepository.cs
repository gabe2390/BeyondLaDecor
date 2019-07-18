using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IPackageRepository : IBaseModelRepository<Package>
    {
    }
    public class PackageRepository : BaseModelRepository<Package>, IPackageRepository
    {
        public PackageRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context, userManager)
        {
        }

    }
}
