using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class ServiceType
    {
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}