using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IInventoryRecordRepository : IBaseModelRepository<InventoryRecord>
    {
    }
    public class InventoryRecordRepository : BaseModelRepository<InventoryRecord>, IInventoryRecordRepository
    {
        public InventoryRecordRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
