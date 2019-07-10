﻿using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class LocationsController : BaseController<Location>
    {
        public LocationsController(ILocationLogic locationLogic) : base(locationLogic)
        {
        }
    }
}