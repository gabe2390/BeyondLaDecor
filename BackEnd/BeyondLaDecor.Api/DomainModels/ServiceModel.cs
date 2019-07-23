using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class ServiceModel : NegotiableCostEntity
    {
        public int ServiceId { get; set; }
        public int ServiceTypeId { get; set; }
        public ServiceTypeModel ServiceType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<VendorModel> Vendors { get; set; }
        public IEnumerable<TaskModel> Tasks { get; set; }
    }
}
