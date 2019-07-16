using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class InventoryRecordsController : BaseController<InventoryRecord>
    {
        public InventoryRecordsController(IInventoryRecordLogic InventoryRecordLogic) : base(InventoryRecordLogic)
        {
        }
    }
}