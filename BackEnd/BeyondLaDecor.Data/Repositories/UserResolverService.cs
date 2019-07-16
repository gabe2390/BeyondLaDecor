using Microsoft.AspNetCore.Http;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public class UserResolverService
    {
        private readonly IHttpContextAccessor Context;
        public UserResolverService(IHttpContextAccessor context)
        {
            Context = context;
        }

        public string GetUser()
        {
            return Context.HttpContext.User?.Identity?.Name;
        }
    }
}
