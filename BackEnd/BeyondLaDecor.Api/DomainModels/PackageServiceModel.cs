namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class PackageServiceModel : DecorEntityApiModel
    {
        public int PackageServiceId { get; set; }
        public int PackageId { get; set; }
        public PackageModel Package { get; set; }
        public int ServiceId { get; set; }
        public ServiceModel Service { get; set; }
    }
}