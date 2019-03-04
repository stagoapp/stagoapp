using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Data.Models;
using WebAPI.Helpers;
using System.Linq.Expressions;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query;
using WebAPI.Data.Dtos;

namespace WebAPI.Services
{
    public interface IEntityService<T, D> 
        where T : Entity
        where D : Dto
    {
        Task<D> Get(int id);
        Task<IEnumerable<D>> Get(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<D>> Get();
        void Add(D entity);
        void Add(IEnumerable<D> entities);        
        void Update(D entity);        
        void Update(IEnumerable<D> entities);
        void Delete(D entity);
        void Delete(int id);
        void Delete(IEnumerable<D> entities);
        void Save();
    }
}