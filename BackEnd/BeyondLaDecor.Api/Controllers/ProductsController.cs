﻿using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ProductsController : BaseController<Product>
    {
        public ProductsController(IProductLogic productLogic) : base(productLogic)
        {
        }
    }
}