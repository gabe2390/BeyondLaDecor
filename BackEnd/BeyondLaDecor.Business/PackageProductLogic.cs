using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageProductLogic : IBusinessLogicBase<PackageProduct>
    {
    }
    public class PackageProductLogic : BusinessLogicBase<PackageProduct>, IPackageProductLogic
    {
        protected PackageProductLogic(IPackageProductRepository repository) : base(repository)
        {
        }
    }
}