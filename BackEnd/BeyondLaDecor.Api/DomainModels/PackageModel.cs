using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class PackageModel : NegotiableCostEntity
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public bool IsCustom { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
        public IEnumerable<ServiceModel> Services { get; set; }
        public IEnumerable<EventModel> Events { get; set; }
    }
}