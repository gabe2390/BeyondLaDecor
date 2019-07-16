using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IPackageRepository : IBaseModelRepository<Package>
    {
    }
    public class PackageRepository : BaseModelRepository<Package>, IPackageRepository
    {
        public PackageRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }

        public override Package Create(Package entity)
        {
            return base.Create(entity);
        }
    }
}
