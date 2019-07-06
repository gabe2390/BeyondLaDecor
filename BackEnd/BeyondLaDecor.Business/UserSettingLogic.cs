using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IUserSettingLogic : IBusinessLogicBase<UserSetting>
    {
    }
    public class UserSettingLogic : BusinessLogicBase<UserSetting>, IUserSettingLogic
    {
        public UserSettingLogic(IUserSettingRepository repository) : base(repository)
        {
        }
    }
}