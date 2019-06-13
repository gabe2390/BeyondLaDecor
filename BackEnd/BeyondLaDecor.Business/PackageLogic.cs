using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageLogic : IBusinessLogicBase<Package>
    {
    }
    public class PackageLogic : BusinessLogicBase<Package>, IPackageLogic
    {
        protected PackageLogic(IPackageRepository repository) : base(repository)
        {
        }
    }
}