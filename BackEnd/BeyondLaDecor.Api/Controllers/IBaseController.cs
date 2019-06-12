using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    public interface IBaseController<TModel> where TModel : class
    {
        ActionResult<ICollection<TModel>> Get();
        ActionResult<TModel> Get(int id);
        ActionResult<TModel> Create(TModel strain);
        ActionResult<TModel> Update(int id, TModel strain);
        void Delete(int id);
    }
}
