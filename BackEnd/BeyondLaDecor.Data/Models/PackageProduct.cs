namespace BeyondLaDecor.Data.Models
{
    public class PackageProduct : DecorEntity
    {
        public int PackageProductId { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}