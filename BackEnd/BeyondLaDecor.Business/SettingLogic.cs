using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface ISettingLogic : IBusinessLogicBase<Setting>
    {
    }
    public class SettingLogic : BusinessLogicBase<Setting>, ISettingLogic
    {
        public SettingLogic(ISettingRepository repository) : base(repository)
        {
        }
    }
}