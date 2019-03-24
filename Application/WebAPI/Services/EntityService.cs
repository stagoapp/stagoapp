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
using WebAPI.Data.Dtos;
using AutoMapper;

namespace WebAPI.Services
{
    public class EntityService<T, D> : IEntityService<T, D>
        where T : Entity
        where D : Dto
    {
        private readonly IEntityRepository<T> _repo;
        private readonly IMapper _mapper;

        public EntityService(IEntityRepository<T> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<D> Get(int id)
        {
            T res = await _repo.Get(id);
            return _mapper.Map<D>(res);
        }

        public async Task<IEnumerable<D>> Get(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> inputs = await _repo.Get(predicate);
            List<D> results = new List<D>();
            foreach(var input in inputs){
                var res = _mapper.Map<D>(input);
                results.Add(res);
            }
            return results.AsEnumerable();
        }

        public async Task<IEnumerable<D>> Get()
        {
            IEnumerable<T> inputs = await _repo.Get();
            List<D> results = new List<D>();
            foreach(var input in inputs){
                var res = _mapper.Map<D>(input);
                results.Add(res);
            }
            return results.AsEnumerable();
        }

        public void Add(D entity)
        {
            _repo.Add(_mapper.Map<T>(entity));
        }

        public void Add(IEnumerable<D> entities)
        {
            List<T> results = new List<T>();
            foreach(var entity in entities){
                var res = _mapper.Map<T>(entity);
                results.Add(res);
            }
            _repo.Add(results);
        }

        public void Update(D entity)
        {
            _repo.Update(_mapper.Map<T>(entity));
        }

        public void Update(IEnumerable<D> entities)
        {
            List<T> results = new List<T>();
            foreach(var entity in entities){
                var res = _mapper.Map<T>(entity);
                results.Add(res);
            }
            _repo.Update(results);
        }

        public void Delete(D entity)
        {
            _repo.Delete(_mapper.Map<T>(entity));
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public void Delete(IEnumerable<D> entities)
        {
            List<T> results = new List<T>();
            foreach(var entity in entities){
                var res = _mapper.Map<T>(entity);
                results.Add(res);
            }
            _repo.Delete(results);
        }

        public void Save()
        {
            _repo.Save();
        }
    }
}