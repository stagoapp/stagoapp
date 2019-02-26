using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Helpers;
using WebAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebAPI.Data.Repositories;
using Microsoft.EntityFrameworkCore.Query;

namespace WebAPI.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {

        private readonly IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<T> Get(int id)
        {
            return await _unitOfWork.Context.Set<T>().Where(t => t.Id == id).FirstOrDefaultAsync<T>();
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate)
        {
            return await _unitOfWork.Context.Set<T>().Where(predicate).ToListAsync<T>();
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _unitOfWork.Context.Set<T>().ToListAsync<T>();
        }

        public void Add(T entity)
        {
            _unitOfWork.Context.Set<T>().Add(entity);
        }

        public void Add(IEnumerable<T> entities)
        {
            foreach(var entity in entities)
            {
                _unitOfWork.Context.Set<T>().Add(entity);
            }
        }

        public void Update(T entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            _unitOfWork.Context.Set<T>().Attach(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            foreach(var entity in entities)
            {
                _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
                _unitOfWork.Context.Set<T>().Attach(entity);
            }
        }

        public void Delete(T entity)
        {
            T existing = _unitOfWork.Context.Set<T>().Find(entity);
            if (existing != null) _unitOfWork.Context.Set<T>().Remove(existing);
        }

        public void Delete(int id)
        {
            T existing = _unitOfWork.Context.Set<T>().Where(t => t.Id == id).FirstOrDefault();
            if (existing != null) _unitOfWork.Context.Set<T>().Remove(existing);
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach(var entity in entities)
            {
                T existing = _unitOfWork.Context.Set<T>().Find(entity);
                if (existing != null) _unitOfWork.Context.Set<T>().Remove(existing);
            }
        }

        public void Save()
        {
            _unitOfWork.Context.SaveChanges();
        }
    }
}