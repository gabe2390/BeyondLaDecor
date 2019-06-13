using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IVendorLogic : IBusinessLogicBase<Vendor>
    {
    }
    public class VendorLogic : BusinessLogicBase<Vendor>, IVendorLogic
    {
        protected VendorLogic(IVendorRepository repository) : base(repository)
        {
        }
    }
}