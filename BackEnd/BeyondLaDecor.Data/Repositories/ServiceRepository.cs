using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IServiceRepository : IBaseModelRepository<Service>
    {
    }
    public class ServiceRepository : BaseModelRepository<Service>, IServiceRepository
    {
        public ServiceRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
