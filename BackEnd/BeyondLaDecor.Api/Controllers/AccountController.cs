using BeyondLaDecor.Beyond.Data;
using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        private SignInManager<User> SignInManager { get; set; }
        private UserManager<User> UserManager { get; set; }
        private BeyondDbContext Context { get; set; }

        public AccountController(BeyondDbContext context, SignInManager<User> signInManager, UserManager<User> userManager)
        {
            SignInManager = signInManager;
            UserManager = userManager;
            Context = context;
        }       

        [HttpPost("[controller]/[action]")]
        public async Task<ActionResult<string>> Login()
        {
            var result = await SignInManager.PasswordSignInAsync("SomeGuy65", "DroopyAss123", true, false);
            var message = result.Succeeded ? "Signed In" : "Errors Signing in.";
            return Content(message);    
        }

        [HttpPost("[controller]/[action]")]
        public async Task<ActionResult<string>> Create()
        {
            var user = new User
            {
                Email = "tabc@gmail.com",
                EmailConfirmed = true,
                IsAdministrator = true,
                City = "Philadelphia",
                State = "PA",
                UserName = "SomeGuy65",
                ZipCode = "19111",
                FirstName = "Hoop",
                LastName = "Droop"
            };
            string password = "DroopyAss123";
            var result = await UserManager.CreateAsync(user, password);
            var message = result.Succeeded ? "User Created" : "Error, User Not Created";
            return Content(message);
        }
    }
}