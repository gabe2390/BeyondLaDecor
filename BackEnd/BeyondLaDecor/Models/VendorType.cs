using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class VendorType
    {
        public int VendorTypeId { get; set; }
        public string TypeName { get; set; }
        public ICollection<Vendor> Vendors { get; set; }
    }
}