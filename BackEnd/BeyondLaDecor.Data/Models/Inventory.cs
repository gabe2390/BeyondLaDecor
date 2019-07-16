using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class Inventory : DecorEntity
    {
        public int InventoryId { get; set; }
        public ICollection<InventoryRecord> InventoryRecords { get; set; }
    }
}
