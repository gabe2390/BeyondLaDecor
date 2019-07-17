using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.DomainModels
{
    public class ProductTypeModel : DecorEntityApiModel
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}