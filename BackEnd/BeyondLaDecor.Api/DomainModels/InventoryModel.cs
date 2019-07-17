using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class InventoryModel : DecorEntityApiModel
    {
        public int InventoryId { get; set; }
        public ICollection<InventoryRecordModel> InventoryRecords { get; set; }
    }
}
