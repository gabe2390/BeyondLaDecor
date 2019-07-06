using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;

namespace BeyondLaDecor.Beyond.Business
{
    public interface ILocationLogic : IBusinessLogicBase<Location>
    {
    }
    public class LocationLogic : BusinessLogicBase<Location>, ILocationLogic
    {
        public LocationLogic(ILocationRepository repository) : base(repository)
        {
        }
    }
}