using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class ProductModel : NegotiableCostEntity
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public ProductTypeModel ProductType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }     
        public bool ThirdParty { get; set; }
        public ICollection<PackageProductModel> PackageProducts { get; set; }
        public ICollection<ProductServiceTypeModel> ProductServiceTypes { get; set; }
        public int? InventoryRecordId { get; set; }
        public InventoryRecordModel InventoryRecord { get; set; }
    }
}
