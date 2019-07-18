using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class ServicesController : BaseController<Service, ServiceModel>
    {
        public ServicesController(IMapper mapper,IServiceLogic serviceLogic) : base(mapper, serviceLogic)
        {
        }
    }
}