using BeyondLaDecor.Beyond.BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public abstract class BaseController<TModel> : ControllerBase, IBaseController<TModel> where TModel : class
    {
        private IBusinessLogicBase<TModel> LogicBase { get; set; }

        public BaseController(IBusinessLogicBase<TModel> logicBase)
        {
            LogicBase = logicBase;
        }

        [HttpGet("[controller]/")]
        public ActionResult<ICollection<TModel>> Get()
        {
            return LogicBase.GetAll().ToList();
        }
        [HttpGet("[controller]/{id}")]
        public ActionResult<TModel> Get(int id)
        {
            return LogicBase.GetEntity(id);
        }

        [HttpGet("[controller]/create")]
        public ActionResult<TModel> Create(TModel model)
        {
            return LogicBase.CreateEntity(model);
        }
        [HttpGet("[controller]/{id}/update")]
        public ActionResult<TModel> Update(int id, TModel model)
        {
            return LogicBase.UpdateEntity(id, model);
        }

        [HttpGet("[controller]/delete")]
        public void Delete(int id)
        {
            LogicBase.DeleteEntity(id);
        }
    }
}
