namespace BeyondLaDecor.Beyond.Data.Models
{
    public class ServiceVendor
    {
        public int ServiceVendorId { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
