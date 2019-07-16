using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IServiceLogic : IBusinessLogicBase<Service>
    {
    }
    public class ServiceLogic : BusinessLogicBase<Service>, IServiceLogic
    {
        public ServiceLogic(IServiceRepository repository) : base(repository)
        {
        }

        public override Service CreateEntity(Service model)
        {
            return base.CreateEntity(model);
        }
    }
}