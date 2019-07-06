using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class ProductServiceType : DecorEntity
    {
        public int ProductServiceTypeId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
