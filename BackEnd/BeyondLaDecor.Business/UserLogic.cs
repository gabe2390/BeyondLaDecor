using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IUserLogic : IBusinessLogicBase<User>
    {
    }
    public class UserLogic : BusinessLogicBase<User>, IUserLogic
    {
        public UserLogic(IUserRepository repository) : base(repository)
        {
        }
    }
}