using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ServicesController : BaseController<Service>
    {
        private IServiceLogic ServiceLogic { get; set; }
        public ServicesController(IServiceLogic serviceLogic) : base(serviceLogic)
        {
            ServiceLogic = serviceLogic;
        }
    }
}