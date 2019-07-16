using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface ITaskRepository : IBaseModelRepository<Task>
    {
    }
    public class TaskRepository : BaseModelRepository<Task>, ITaskRepository
    {
        public TaskRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
