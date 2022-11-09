using Microsoft.EntityFrameworkCore;
using NkwoTheApp.Persistence.Context;
using NkwoTheApp.Persistence.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NkwoTheApp.Persistence.Repository.Services
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected NkwoTheAppContext _nkwoTheAppContext;
        public RepositoryBase(NkwoTheAppContext nkwoTheAppContext)
        {
            _nkwoTheAppContext = nkwoTheAppContext;
        }
        public void Create(T entity)
        {
            _nkwoTheAppContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _nkwoTheAppContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll(bool trackChanges)
        {
            return !trackChanges ? _nkwoTheAppContext.Set<T>()
                .AsNoTracking() : _nkwoTheAppContext.Set<T>();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges ? _nkwoTheAppContext.Set<T>()
                .Where(expression).AsNoTracking() : _nkwoTheAppContext.Set<T>()
                .Where(expression); 
        }

        public void Update(T entity)
        {
            _nkwoTheAppContext.Set<T>().Update(entity);
        }
    }
}
