using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface ILaDecorUserManager
    {
        User GetUser();
    }
    public class LaDecorUserManager : ILaDecorUserManager
    {
        private readonly UserManager<User> UserManager;
        private readonly IHttpContextAccessor Accessor;

        //refactor to not be coupled to http context accessor - aspnetcore.http (configure identity/authentication server
        public LaDecorUserManager(UserManager<User> userManager, IHttpContextAccessor accessor)
        {
            UserManager = userManager;
            Accessor = accessor;
        }
        //fix this to actually work. this is fine for testing and building
        public User GetUser()
        {
            return  UserManager.Users.First();
        }
    }
}