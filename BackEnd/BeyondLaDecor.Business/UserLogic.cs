using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IUserLogic : IBusinessLogicBase<User>
    {
    }
    public class UserLogic : BusinessLogicBase<User>, IUserLogic
    {
        protected UserLogic(IUserRepository repository) : base(repository)
        {
        }
    }
}