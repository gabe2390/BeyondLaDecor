using AutoMapper;
using BeyondLaDecor.Beyond.Business;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BeyondLaDecor.Beyond.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public abstract class BaseController<TModel, TApiModel> : ControllerBase, IBaseController<TModel, TApiModel>
        where TModel : class 
        where TApiModel : class
    {
        private IBusinessLogicBase<TModel> LogicBase { get; set; }
        internal IMapper Mapper { get; set; }
        public BaseController(IMapper mapper, IBusinessLogicBase<TModel> logicBase)
        {
            Mapper = mapper;
            LogicBase = logicBase;
        }

        internal TApiModel Map(TModel model)
        {
            return Mapper.Map<TApiModel>(model);
        }
        internal IEnumerable<TApiModel> Map(IEnumerable<TModel> models)
        {
            return models.Select(Map);
        }

        [HttpGet("[controller]/")]
        public IEnumerable<TApiModel> Get()
        {
          return  Map(LogicBase.GetAll());
        }
        [HttpGet("[controller]/{id}")]
        public TApiModel Get(int id)
        {
            return Map(LogicBase.GetEntity(id));
        }

        [HttpPost("[controller]/create")]
        public TApiModel Create(TModel model)
        {
            return Map(LogicBase.CreateEntity(model));
        }
        [HttpPut("[controller]/{id}/update")]
        public TApiModel Update(int id, TModel model)
        {
            return Map(LogicBase.UpdateEntity(id, model));
        }

        [HttpDelete("[controller]/delete")]
        public void Delete(int id)
        {
            LogicBase.DeleteEntity(id);
        }
    }
}
