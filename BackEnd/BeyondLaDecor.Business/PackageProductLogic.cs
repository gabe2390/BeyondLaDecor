using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageProductLogic : IBusinessLogicBase<PackageProduct>
    {
    }
    public class PackageProductLogic : BusinessLogicBase<PackageProduct>, IPackageProductLogic
    {
        public PackageProductLogic(IPackageProductRepository repository) : base(repository)
        {
        }
    }
}