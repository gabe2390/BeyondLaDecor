using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class VendorModel : DecorEntityApiModel
    {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceTypeModel ServiceType { get; set; }
        public ICollection<ServiceVendorModel> ServiceVendors { get; set; }
        public ICollection<LocationModel> Locations { get; set; }
    }
}
