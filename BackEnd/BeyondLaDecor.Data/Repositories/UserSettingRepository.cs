using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IUserSettingRepository : IBaseModelRepository<UserSetting>
    {
    }
    public class UserSettingRepository : BaseModelRepository<UserSetting>, IUserSettingRepository
    {
        public UserSettingRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
