using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class ServiceTypeModel : DecorEntityApiModel
    {
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }
        public int? ParentServiceTypeId { get; set; }
        public ServiceTypeModel ParentServiceType { get; set; }
        public ICollection<ServiceTypeModel> ChildServiceTypes { get; set; }
        public ICollection<ServiceModel> Services { get; set; }
        public ICollection<VendorModel> Vendors { get; set; }
        public ICollection<ProductServiceTypeModel> ProductServiceTypes { get; set; }
    }
}