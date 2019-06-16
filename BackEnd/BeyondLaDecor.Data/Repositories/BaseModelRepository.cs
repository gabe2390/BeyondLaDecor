using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BeyondLaDecor.Beyond.Data.Repositories
{
    public interface IBaseModelRepository<TModel> where TModel : class
    {
        TModel Get(int id);
        IEnumerable<TModel> Get();
        IEnumerable<TModel> Get(Expression<Func<TModel, bool>> expression);
        TModel Create(TModel entity);
        TModel Update(int id, TModel entity);
        void Delete(int id);
        void Validate(int id, ConcurrentQueue<Exception> exceptions);
    }

    public class BaseModelRepository<TModel> : IBaseModelRepository<TModel> where TModel : class
    {
        protected readonly BeyondDbContext Context;

        public BaseModelRepository(BeyondDbContext context)
        {
            Context = context;
        }

        public virtual TModel Create(TModel entity)
        {
            Context.Set<TModel>().Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public virtual void Delete(int id)
        {
            var entity = Context.Set<TModel>().Find(id);
            if (entity != null)
            {
                Context.Set<TModel>().Remove(entity);
                Context.SaveChanges();
                return;
            }
            throw new Exception($"Entity of type {typeof(TModel)} with Id of {id} not found");
        }

        public virtual TModel Get(int id)
        {
            return Context.Set<TModel>().Find(id);
        }

        public virtual IEnumerable<TModel> Get()
        {
            return Context.Set<TModel>().ToList();
        }
        public virtual IEnumerable<TModel> Get(Expression<Func<TModel, bool>> expression)
        {
            return Context.Set<TModel>().Where(expression);
        }

        public virtual TModel Update(int id, TModel entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.Set<TModel>().Attach(entity);
            return entity;
        }

        public void Validate(int id, ConcurrentQueue<Exception> exceptions)
        {
            if (Context.Set<TModel>().Find(id) == null) exceptions.Enqueue(new Exception($"{nameof(TModel)} with ID {id} not found"));
        }
    }

}