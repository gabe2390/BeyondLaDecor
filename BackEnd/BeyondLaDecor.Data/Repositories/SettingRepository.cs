using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface ISettingRepository : IBaseModelRepository<Setting>
    {
    }
    public class SettingRepository : BaseModelRepository<Setting>, ISettingRepository
    {
        public SettingRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
