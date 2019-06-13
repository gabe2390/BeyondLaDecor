using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class ClientsController : BaseController<Client>
    {
        public ClientsController(IClientLogic clientLogic) : base(clientLogic)
        {
        }
    }
}