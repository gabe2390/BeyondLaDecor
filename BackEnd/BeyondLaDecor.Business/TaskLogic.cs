using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface ITaskLogic : IBusinessLogicBase<Task>
    {
    }
    public class TaskLogic : BusinessLogicBase<Task>, ITaskLogic
    {
        public TaskLogic(ITaskRepository repository) : base(repository)
        {
        }
    }
}