using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class InventoryController : BaseController<Inventory, InventoryModel>
    {
        public InventoryController(IMapper mapper, IInventoryLogic inventoryLogic) : base(mapper, inventoryLogic)
        {
        }
    }
}