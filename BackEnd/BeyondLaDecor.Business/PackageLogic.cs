using BeyondLaDecor.Beyond.Data.Models;
using BeyondLaDecor.Beyond.Data.Repositories;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageLogic : IBusinessLogicBase<Package>
    {
        IEnumerable<Service> GetServicesByPackage(int packageId);
    }
    public class PackageLogic : BusinessLogicBase<Package>, IPackageLogic
    {
        private IPackageRepository PackageRepository { get; set; }
        private IPackageServiceRepository PackageServiceRepository { get; set; }
        private IPackageProductRepository PackageProductRepository { get; set; }
        public PackageLogic(IPackageRepository repository, IPackageServiceRepository packageServiceRepository) : base(repository)
        {
            PackageRepository = repository;
            PackageServiceRepository = packageServiceRepository;
        }
        public Package PackageDetail(int packageId)
        {
            var package = PackageRepository.Get(packageId);
            package.PackageProducts = (ICollection<PackageProduct>)PackageServiceRepository.GetAll(e => e.PackageId == packageId, new[] { "Service" });
            package.PackageServices = (ICollection<PackageService>)PackageServiceRepository.GetAll(e => e.PackageId == packageId, new[] { "Service" });
            return package;
        }

        public IEnumerable<Service> GetServicesByPackage(int packageId)
        {
            return PackageServiceRepository.GetAll(e => e.PackageId == packageId, new[] { "Service" })
                .Select(e => e.Service);
        }
        public IEnumerable<Product> GetProductsByPackage(int packageId)
        {
            return PackageProductRepository.GetAll(e => e.PackageId == packageId, new[] { "Product" })
                .Select(e => e.Product);
        }
    }
}