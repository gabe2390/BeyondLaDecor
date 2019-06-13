using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IVendorTypeLogic : IBusinessLogicBase<VendorType>
    {
    }
    public class VendorTypeLogic : BusinessLogicBase<VendorType>, IVendorTypeLogic
    {
        protected VendorTypeLogic(IVendorTypeRepository repository) : base(repository)
        {
        }
    }
}