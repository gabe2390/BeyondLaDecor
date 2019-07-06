using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class ServiceType : DecorEntity
    {
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }
        public int? ParentServiceTypeId { get; set; }
        public ServiceType ParentServiceType { get; set; }
        public ICollection<ServiceType> ChildServiceTypes { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Vendor> Vendors { get; set; }
        public ICollection<ProductServiceType> ProductServiceTypes { get; set; }
    }
}