using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IClientLogic : IBusinessLogicBase<Client>
    {
    }
    public class ClientLogic : BusinessLogicBase<Client>, IClientLogic
    {
        protected ClientLogic(IClientRepository repository) : base(repository)
        {
        }
    }
}