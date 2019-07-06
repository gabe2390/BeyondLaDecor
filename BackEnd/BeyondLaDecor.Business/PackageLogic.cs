using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageLogic : IBusinessLogicBase<Package>
    {
    }
    public class PackageLogic : BusinessLogicBase<Package>, IPackageLogic
    {
        public PackageLogic(IPackageRepository repository) : base(repository)
        {
        }
    }
}