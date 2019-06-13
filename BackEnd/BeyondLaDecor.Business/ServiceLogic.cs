using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IServiceLogic : IBusinessLogicBase<Service>
    {
    }
    public class ServiceLogic : BusinessLogicBase<Service>, IServiceLogic
    {
        protected ServiceLogic(IServiceRepository repository) : base(repository)
        {
        }
    }
}