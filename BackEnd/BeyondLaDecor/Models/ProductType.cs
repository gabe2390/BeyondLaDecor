﻿using System.Collections.Generic;

namespace BeyondLaDecor.Data.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}