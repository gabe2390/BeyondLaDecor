using BeyondLaDecor.Data.Models;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IClientRepository : IBaseModelRepository<Client>
    {
    }
    public class ClientRepository : BaseModelRepository<Client>, IClientRepository
    {
        public ClientRepository(BeyondDbContext context) : base(context)
        {
        }
    }
}
