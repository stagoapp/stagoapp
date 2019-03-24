using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Data.Models;
using WebAPI.Helpers;
using System.Linq.Expressions;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;

namespace WebAPI.Data.Repositories
{
    public interface IEntityRepository<T> where T : Entity
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> Get();
        void Add(T entity);
        void Add(IEnumerable<T> entities);        
        void Update(T entity);        
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(int id);
        void Delete(IEnumerable<T> entities);
        void Save();

        // IQueryable<T> Query(string sql, params object[] parameters);
        
        // T Search(params object[] keyValues);
        
        // T Single(Expression<Func<T, bool>> predicate = null,
        //     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //     Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        //     bool disableTracking = true);        
    }
}