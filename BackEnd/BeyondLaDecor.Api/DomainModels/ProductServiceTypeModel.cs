using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class ProductServiceTypeModel 
    {
        public int ProductServiceTypeId { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceTypeModel ServiceType { get; set; }
    }
}
