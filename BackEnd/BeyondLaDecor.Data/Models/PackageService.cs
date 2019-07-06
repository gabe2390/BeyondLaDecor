namespace BeyondLaDecor.Beyond.Data.Models
{
    public class PackageService : DecorEntity
    {
        public int PackageServiceId { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
    }
}