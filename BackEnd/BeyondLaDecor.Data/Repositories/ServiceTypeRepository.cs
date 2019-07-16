using BeyondLaDecor.Beyond.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IServiceTypeRepository : IBaseModelRepository<ServiceType>
    {
    }
    public class ServiceTypeRepository : BaseModelRepository<ServiceType>, IServiceTypeRepository
    {
        public ServiceTypeRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context,userManager) 
        {
        }
    }
}
