namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class InventoryRecordModel
    {
        public int InventoryRecordId { get; set; }
        public int InventoryId { get; set; }
        public InventoryModel Inventory { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }
    }
}