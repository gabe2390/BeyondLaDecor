using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IInventoryLogic : IBusinessLogicBase<Inventory>
    {
    }
    public class InventoryLogic : BusinessLogicBase<Inventory>, IInventoryLogic
    {
        public InventoryLogic(IInventoryRepository repository) : base(repository)
        {
        }
    }
}