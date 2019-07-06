using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class Vendor : DecorEntity
    {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
        public ICollection<ServiceVendor> ServiceVendors { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}
