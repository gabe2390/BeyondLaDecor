using System;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class LocationModel : DecorEntityApiModel
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public ICollection<EventLocationModel> EventLocations { get; set; }
        public int? VendorId { get; set; }
        public VendorModel Vendor { get; set; }
    }
}