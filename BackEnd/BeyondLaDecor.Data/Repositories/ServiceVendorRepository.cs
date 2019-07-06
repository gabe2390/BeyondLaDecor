using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IServiceVendorRepository : IBaseModelRepository<ServiceVendor>
    {
    }
    public class ServiceVendorRepository : BaseModelRepository<ServiceVendor>, IServiceVendorRepository
    {
        public ServiceVendorRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}