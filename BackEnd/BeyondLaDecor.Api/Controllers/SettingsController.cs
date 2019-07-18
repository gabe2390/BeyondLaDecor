using AutoMapper;
using BeyondLaDecor.Beyond.Api.DomainModels;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data.Models;
namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public class SettingsController : BaseController<Setting, SettingModel>
    {
        public SettingsController(IMapper mapper, ISettingLogic settingLogic) : base(mapper, settingLogic)
        {
        }
    }
}