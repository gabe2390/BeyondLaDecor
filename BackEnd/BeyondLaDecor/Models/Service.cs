using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class Service : DecorEntity
    {
        public int ServiceId { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceType ServiceType { get; set; }
        public string Name { get; set; }
        public ICollection<PackageService> PackageServices { get; set; }
        public ICollection<ServiceVendor> ServiceVendors { get; set; }
    }
}
