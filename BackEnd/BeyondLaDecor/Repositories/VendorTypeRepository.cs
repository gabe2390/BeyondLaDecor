using BeyondLaDecor.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IVendorTypeRepository : IBaseModelRepository<VendorType>
    {
    }
    public class VendorTypeRepository : BaseModelRepository<VendorType>, IVendorTypeRepository
    {
        public VendorTypeRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
