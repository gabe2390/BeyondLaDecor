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
        TModel Get(Expression<Func<TModel, bool>> expression, string[] includes = null);
        IQueryable<TModel> GetAll(string[] includes   = null);
        IQueryable<TModel> GetAll(Expression<Func<TModel, bool>> expression, string[] includes = null);
        TModel Create(TModel entity);
        TModel Update(int id, TModel entity);
        void Delete(int id);
        void Validate(int id, ConcurrentQueue<Exception> exceptions);
        TModel Get(int id);
    }

    public abstract class BaseModelRepository<TModel> : IBaseModelRepository<TModel> where TModel : class
    {
        protected readonly BeyondDbContext Context;
        internal readonly ILaDecorUserManager UserManager;
        protected User CurrentUser { get; set; }

        public BaseModelRepository(BeyondDbContext context, ILaDecorUserManager userManager)
        {
            Context = context;
            UserManager = userManager;
            CurrentUser = GetCurrentUser();
        }

        private User GetCurrentUser()
        {
            return UserManager.GetUser();
        }

        public virtual TModel Create(TModel entity)
        {
            AssignAdministrator(entity);
            Context.Set<TModel>().Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public void AssignAdministrator(TModel entity)
        {
            if (CanAssignAdministrator())
            {
                (entity as DecorEntity).AdministratorId = CurrentUser.Id;
            }
        }

        private bool CanAssignAdministrator()
        {
            return typeof(TModel).IsSubclassOf(typeof(DecorEntity)) && CurrentUser.IsAdministrator;
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

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }

            Context.Entry(entity).State = EntityState.Modified;
            Context.Set<TModel>().Attach(entity);
            return entity;
        }

        public virtual TModel Get(Expression<Func<TModel, bool>> expression, string[] includes = null)
        {
            var queryWithIncludes = GetIncludedQuery(includes);
            return queryWithIncludes.FirstOrDefault(expression);
        }

        public virtual IQueryable<TModel> GetAll(string[] includes = null)
        {
            var queryWithIncludes = CanAssignAdministrator() ?
                GetAll(AdministratorFilter(), includes) :
                GetIncludedQuery(includes);
            return queryWithIncludes;
        }

        private Expression<Func<TModel, bool>> AdministratorFilter()
        {
            return e => (e as DecorEntity).AdministratorId == CurrentUser.Id || !(e as DecorEntity).AdministratorId.HasValue;
        }

        public virtual IQueryable<TModel> GetAll(Expression<Func<TModel, bool>> expression, string[] includes = null)
        {
            var queryWithIncludes = CanAssignAdministrator() ?
                GetIncludedQuery(includes).Where(AdministratorFilter()) : GetIncludedQuery(includes);
            return queryWithIncludes.Where(expression);
        }

        public void Validate(int id, ConcurrentQueue<Exception> exceptions)
        {
            if (Context.Set<TModel>().Find(id) == null)
            {
                exceptions.Enqueue(new Exception($"{nameof(TModel)} with ID {id} not found"));
            }
        }

        private IQueryable<TModel> GetIncludedQuery(string[] includes)
        {
            IQueryable<TModel> query = Context.Set<TModel>();
            if (includes != null)
            {
                query = ApplyIncludes(query, includes);
            }
            return query;
        }

        private IQueryable<TModel> ApplyIncludes(IQueryable<TModel> query, string[] includes)
        {
            return includes.Aggregate(query, (set, path) => set.Include(path));
        }

        public TModel Get(int id)
        {
            return Context.Set<TModel>().Find(id);
        }
    }
}