using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class UsersController : BaseController<User, UserModel>
    {
        public UsersController(IMapper mapper, IUserLogic userLogic) : base(mapper, userLogic)
        {
        }
    }
}