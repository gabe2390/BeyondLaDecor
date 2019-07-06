using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class UserSettingsController : BaseController<UserSetting>
    {
        public UserSettingsController(IUserSettingLogic userSettingLogic) : base(userSettingLogic)
        {
        }
    }
}