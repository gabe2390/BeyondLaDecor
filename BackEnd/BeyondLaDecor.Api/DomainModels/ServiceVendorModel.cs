namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class ServiceVendorModel
    {
        public int ServiceVendorId { get; set; }
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }
        public int VendorId { get; set; }
        public VendorModel Vendor { get; set; }
    }
}
