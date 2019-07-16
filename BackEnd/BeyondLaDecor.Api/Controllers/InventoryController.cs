using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class InventoryController : BaseController<Inventory>
    {
        public InventoryController(IInventoryLogic inventoryLogic) : base(inventoryLogic)
        {
        }
    }
}