using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class PackageModel : NegotiableCostEntity
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public bool IsCustom { get; set; }
        public ICollection<PackageProductModel> PackageProducts { get; set; }
        public ICollection<PackageServiceModel> PackageServices { get; set; }
        public ICollection<EventModel> Events { get; set; }
    }
}