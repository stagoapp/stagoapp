using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAPI.Data.Dtos;
using WebAPI.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Services;
using System.Linq.Expressions;
using WebAPI.Helpers;

namespace WebAPI.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController<T, D> : ControllerBase
        where T : Entity
        where D : Dto
    {
        private readonly IEntityService<T, D> _serv;

        [HttpGet]
        public async Task<D> Get(int id)
        {
            return await _serv.Get(id);
        }

        [HttpGet]
        public async Task<IAsyncEnumerable<D>> Get(Expression<Func<T, bool>> predicate)
        {
            return await _serv.Get(predicate);
        }

        [HttpGet]
        public async Task<IAsyncEnumerable<D>> Get()
        {
            return await _serv.Get();
        }

        [HttpPost]
        public void Add(D entity)
        {
            _serv.Add(entity);
        }

        [HttpPost]
        public void Add(IEnumerable<D> entities)
        {
            _serv.Add(entities);
        }

        [HttpPut]
        public void Update(D entity)
        {
            _serv.Update(entity);
        }

        [HttpPut]
        public void Update(IEnumerable<D> entities)
        {
            _serv.Update(entities);
        }

        [HttpDelete]
        public void Delete(D entity)
        {
            _serv.Delete(entity);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _serv.Delete(id);
        }

        [HttpDelete]
        public void Delete(IEnumerable<D> entities)
        {
            _serv.Delete(entities);
        }
    }
}