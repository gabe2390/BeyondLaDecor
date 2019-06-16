using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    internal class UsersController : BaseController<User>
    {
        public UsersController(IUserLogic userLogic) : base(userLogic)
        {
        }
    }
}