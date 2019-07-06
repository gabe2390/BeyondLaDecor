using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IVendorRepository : IBaseModelRepository<Vendor>
    {
    }
    public class VendorRepository : BaseModelRepository<Vendor>, IVendorRepository
    {
        public VendorRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
