using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IServiceVendorLogic : IBusinessLogicBase<ServiceVendor>
    {
    }
    public class ServiceVendorLogic : BusinessLogicBase<ServiceVendor>, IServiceVendorLogic
    {
        public ServiceVendorLogic(IServiceVendorRepository repository) : base(repository)
        {
        }
    }
}