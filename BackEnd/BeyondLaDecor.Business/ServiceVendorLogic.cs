using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IServiceVendorLogic : IBusinessLogicBase<ServiceVendor>
    {
    }
    public class ServiceVendorLogic : BusinessLogicBase<ServiceVendor>, IServiceVendorLogic
    {
        protected ServiceVendorLogic(IServiceVendorRepository repository) : base(repository)
        {
        }
    }
}