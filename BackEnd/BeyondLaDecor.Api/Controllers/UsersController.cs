using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class UsersController : BaseController<User>
    {
        public UsersController(IUserLogic userLogic) : base(userLogic)
        {
        }
    }
}