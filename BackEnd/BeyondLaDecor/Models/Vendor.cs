namespace BeyondLaDecor.Data.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string Name { get; set; }
        public int VendorTypeId { get; set; }
        public VendorType VendorType { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
