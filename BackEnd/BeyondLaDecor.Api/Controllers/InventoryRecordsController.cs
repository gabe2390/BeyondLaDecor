using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class InventoryRecordsController : BaseController<InventoryRecord, InventoryRecordModel>
    {
        public InventoryRecordsController(IMapper mapper, IInventoryRecordLogic inventoryRecordLogic) : base(mapper, inventoryRecordLogic)
        {
        }
    }
}