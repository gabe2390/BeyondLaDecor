using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IServiceRepository : IBaseModelRepository<Service>
    {
    }
    public class ServiceRepository : BaseModelRepository<Service>, IServiceRepository
    {
        public ServiceRepository(BeyondDbContext context, ILaDecorUserManager userManager) : base(context, userManager)
        {
        }

        public override Service Create(Service entity)
        {
            if (CurrentUser.IsAdministrator)
            {
                entity.AdministratorId = CurrentUser.Id;
            }
            return base.Create(entity);
        }
    }
}
