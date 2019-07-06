using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class SettingsController : BaseController<Setting>
    {
        public SettingsController(ISettingLogic settingLogic) : base(settingLogic)
        {
        }
    }
}