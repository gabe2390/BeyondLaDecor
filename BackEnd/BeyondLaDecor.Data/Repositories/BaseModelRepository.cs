using BeyondLaDecor.Beyond.Data.Models;
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
        TModel Get(int id, string[] includes = null);
        IEnumerable<TModel> Get(string[] includes = null);
        IEnumerable<TModel> Get(Expression<Func<TModel, bool>> expression, string[] includes = null);
        TModel Create(TModel entity);
        TModel Update(int id, TModel entity);
        void Delete(int id);
        void Validate(int id, ConcurrentQueue<Exception> exceptions);
    }

    public abstract class BaseModelRepository<TModel> : IBaseModelRepository<TModel> where TModel : class
    {
        protected readonly BeyondDbContext Context;
        protected User CurrentUser { get; set; }

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

        public virtual TModel Update(int id, TModel entity)
        {
            var exceptions = new ConcurrentQueue<Exception>();
            Validate(id, exceptions);

            if (exceptions.Any()) throw new AggregateException(exceptions);

            Context.Entry(entity).State = EntityState.Modified;
            Context.Set<TModel>().Attach(entity);
            return entity;
        }

        public virtual TModel Get(int id, string[] includes = null)
        {
            var queryWithIncludes = GetIncludedQuery(includes);
            return queryWithIncludes.Find(id);
        }

        public virtual IEnumerable<TModel> Get(string[] includes = null)
        {
            var queryWithIncludes = GetIncludedQuery(includes);
            return queryWithIncludes.AsEnumerable();
        }
        public virtual IEnumerable<TModel> Get(Expression<Func<TModel, bool>> expression, string[] includes = null)
        {
            var queryWithIncludes = GetIncludedQuery(includes);
            return queryWithIncludes.Where(expression);
        }

        public void Validate(int id, ConcurrentQueue<Exception> exceptions)
        {
            if (Context.Set<TModel>().Find(id) == null) exceptions.Enqueue(new Exception($"{nameof(TModel)} with ID {id} not found"));
        }

        private DbSet<TModel> GetIncludedQuery(string[] includes)
        {
            DbSet<TModel> query = Context.Set<TModel>();
            ApplyIncludes(query, includes);
            return query;
        }

        private void ApplyIncludes(DbSet<TModel> query, string[] includes)
        {
            foreach (var include in includes) query.Include(include);
        }

        private void ApplyDecorIdFilter()
        {

        }
    }

}