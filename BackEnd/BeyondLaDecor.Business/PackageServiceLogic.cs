using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageServiceLogic : IBusinessLogicBase<PackageService>
    {
    }
    public class PackageServiceLogic : BusinessLogicBase<PackageService>, IPackageServiceLogic
    {
        public PackageServiceLogic(IPackageServiceRepository repository) : base(repository)
        {
        }
    }
}