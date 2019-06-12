﻿using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ThirdParty { get; set; }
        public decimal Price { get; set; }
        public ICollection<PackageProduct> PackageProducts { get; set; }
    }
}
