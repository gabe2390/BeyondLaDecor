using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class Package : DecorEntity
    {
        public int PackageId { get; set; }
        public string Name { get; set; }
        public ICollection<PackageProduct> PackageProducts { get; set; }
        public ICollection<PackageService> PackageServices { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
