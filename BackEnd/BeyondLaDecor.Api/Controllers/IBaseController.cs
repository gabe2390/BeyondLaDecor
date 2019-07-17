using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public interface IBaseController<TModel, TApiModel> where TModel : class where TApiModel : class
    {
        IEnumerable<TApiModel> Get();
        TApiModel Get(int id);
        TApiModel Create(TModel strain);
        TApiModel Update(int id, TModel model);
        void Delete(int id);
    }
}
