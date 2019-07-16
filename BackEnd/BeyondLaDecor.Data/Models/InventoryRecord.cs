﻿namespace BeyondLaDecor.Beyond.Data.Models
{
    public class InventoryRecord
    {
        public int InventoryRecordId { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}