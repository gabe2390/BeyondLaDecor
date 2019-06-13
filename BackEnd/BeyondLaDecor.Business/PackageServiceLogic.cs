using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageServiceLogic : IBusinessLogicBase<PackageService>
    {
    }
    public class PackageServiceLogic : BusinessLogicBase<PackageService>, IPackageServiceLogic
    {
        protected PackageServiceLogic(IPackageServiceRepository repository) : base(repository)
        {
        }
    }
}