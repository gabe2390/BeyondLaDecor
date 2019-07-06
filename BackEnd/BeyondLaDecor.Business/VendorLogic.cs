using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IVendorLogic : IBusinessLogicBase<Vendor>
    {
    }
    public class VendorLogic : BusinessLogicBase<Vendor>, IVendorLogic
    {
        public VendorLogic(IVendorRepository repository) : base(repository)
        {
        }
    }
}