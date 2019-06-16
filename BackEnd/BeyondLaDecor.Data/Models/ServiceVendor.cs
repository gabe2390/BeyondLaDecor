namespace BeyondLaDecor.Data.Models
{
    public class ServiceVendor : DecorEntity
    {
        public int ServiceVendorId { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
