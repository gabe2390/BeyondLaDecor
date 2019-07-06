using System;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public ICollection<EventLocation> EventLocations { get; set; }
        public int? VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}