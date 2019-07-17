namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class PackageProductModel 
    {
        public int PackageProductId { get; set; }
        public int PackageId { get; set; }
        public PackageModel Package { get; set; }
        public int ProductId { get; set; }
        public ProductModel Product { get; set; }
    }
}