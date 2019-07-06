using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IServiceTypeLogic : IBusinessLogicBase<ServiceType>
    {
    }
    public class ServiceTypeLogic : BusinessLogicBase<ServiceType>, IServiceTypeLogic
    {
        public ServiceTypeLogic(IServiceTypeRepository repository) : base(repository)
        {
        }
    }
}