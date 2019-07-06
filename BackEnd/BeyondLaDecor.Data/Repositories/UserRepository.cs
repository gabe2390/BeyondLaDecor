using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IUserRepository : IBaseModelRepository<User>
    {
    }
    public class UserRepository : BaseModelRepository<User>, IUserRepository
    {
        public UserRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
