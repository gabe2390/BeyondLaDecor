using BeyondLaDecor.Beyond.Data.Repositories;
using System.Collections.Generic;

namespace BeyondLaDecor.Beyond.Business
{
    public interface IBusinessLogicBase<TModel> where TModel : class
    {
        TModel CreateEntity(TModel model);
        TModel GetEntity(int id);
        IEnumerable<TModel> GetAll();
        TModel UpdateEntity(int id, TModel model);
        void DeleteEntity(int id);
    }

    public abstract class BusinessLogicBase<TModel> : IBusinessLogicBase<TModel> where TModel : class
    {

        public BusinessLogicBase(IBaseModelRepository<TModel> repository)
        {
            Repository = repository;
        }

        IBaseModelRepository<TModel> Repository { get; set; }
        public virtual TModel CreateEntity(TModel model)
        {
            return Repository.Create(model);
        }

        public virtual void DeleteEntity(int id)
        {
            Repository.Delete(id);
        }

        public IEnumerable<TModel> GetAll()
        {
            return Repository.Get();
        }

        public virtual TModel GetEntity(int id)
        {
            return Repository.Get(id);
        }

        public virtual TModel UpdateEntity(int id, TModel model)
        {
            return Repository.Update(id, model);
        }
    }
}
