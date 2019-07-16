using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IInventoryRepository : IBaseModelRepository<Inventory>
    {
    }
    public class InventoryRepository : BaseModelRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
