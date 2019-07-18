using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class UserSettingsController : BaseController<UserSetting, UserSettingModel>
    {
        public UserSettingsController(IMapper mapper, IUserSettingLogic userSettingLogic) : base(mapper, userSettingLogic)
        {
        }
    }
}