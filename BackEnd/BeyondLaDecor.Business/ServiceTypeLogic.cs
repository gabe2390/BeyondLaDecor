﻿using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IServiceTypeLogic : IBusinessLogicBase<ServiceType>
    {
    }
    public class ServiceTypeLogic : BusinessLogicBase<ServiceType>, IServiceTypeLogic
    {
        protected ServiceTypeLogic(IServiceTypeRepository repository) : base(repository)
        {
        }
    }
}