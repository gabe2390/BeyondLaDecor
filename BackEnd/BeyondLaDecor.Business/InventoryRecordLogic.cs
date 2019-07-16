using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IInventoryRecordLogic : IBusinessLogicBase<InventoryRecord>
    {
    }
    public class InventoryRecordLogic : BusinessLogicBase<InventoryRecord>, IInventoryRecordLogic
    {
        public InventoryRecordLogic(IInventoryRecordRepository repository) : base(repository)
        {
        }
    }
}