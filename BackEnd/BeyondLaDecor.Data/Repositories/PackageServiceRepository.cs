using BeyondLaDecor.Beyond.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IPackageServiceRepository : IBaseModelRepository<PackageService>
    {
    }
    public class PackageServiceRepository : BaseModelRepository<PackageService>, IPackageServiceRepository
    {
        public PackageServiceRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
