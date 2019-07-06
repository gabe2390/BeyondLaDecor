﻿using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Models
{
    public class ProductType : DecorEntity
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}