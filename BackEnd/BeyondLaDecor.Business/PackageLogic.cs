using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageLogic : IBusinessLogicBase<Package>
    {
        IEnumerable<Service> GetServicesByPackage(int packageId);
    }
    public class PackageLogic : BusinessLogicBase<Package>, IPackageLogic
    {
        private IPackageServiceRepository PackageServiceRepository { get; set; }
        public PackageLogic(IPackageRepository repository, IPackageServiceRepository packageServiceRepository) : base(repository)
        {
            PackageServiceRepository = packageServiceRepository;
        }

        public IEnumerable<Service> GetServicesByPackage(int packageId)
        {
            return PackageServiceRepository.Get(e => e.PackageId == packageId).Select(e => e.Service);
        }
    }
}