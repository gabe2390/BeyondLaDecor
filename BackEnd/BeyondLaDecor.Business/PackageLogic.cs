using BeyondLaDecor.Beyond.Data.Models;
using BeyondLaDecor.Beyond.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IPackageLogic : IBusinessLogicBase<Package>
    {
        IEnumerable<Service> GetServicesByPackage(int packageId);
        Package PackageDetail(int packageId);

    }
    public class PackageLogic : BusinessLogicBase<Package>, IPackageLogic
    {
        private IPackageRepository PackageRepository { get; set; }
        private IPackageServiceRepository PackageServiceRepository { get; set; }
        private IPackageProductRepository PackageProductRepository { get; set; }
        public PackageLogic(
            IPackageRepository repository,
            IPackageServiceRepository packageServiceRepository,
            IPackageProductRepository packageProductRepository) : base(repository)
        {
            PackageRepository = repository;
            PackageServiceRepository = packageServiceRepository;
            PackageProductRepository = packageProductRepository;
        }

        public Package PackageDetail(int packageId)
        {
            var package = PackageRepository.Get(packageId);
            package.PackageProducts = PackageProductRepository.GetAll(e => e.PackageId == packageId, new[] { "Product" }).ToList();
            package.PackageServices = PackageServiceRepository.GetAll(e => e.PackageId == packageId, new[] { "Service" }).ToList();
            return package;
        }

        public IEnumerable<Service> GetServicesByPackage(int packageId)
        {
            return PackageServiceRepository.GetAll(e => e.PackageId == packageId, new[] { "Service" }).Select(e => e.Service);
        }
        public IEnumerable<Product> GetProductsByPackage(int packageId)
        {
            return PackageProductRepository.GetAll(e => e.PackageId == packageId, new[] { "Product" }).Select(e => e.Product);
        }
    }
}