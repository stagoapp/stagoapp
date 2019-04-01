using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Helpers;
using WebAPI.Data.Dtos;
using WebAPI.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Repositories;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : EntityController<User, UserDto>
    {
        private readonly IUserService<User, UserDto> _serv;
        private readonly IMapper _mapper;

        public UsersController(IUserService<User, UserDto> serv, IMapper mapper)
        {
            _mapper = mapper;
            _serv = serv;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery]UserParams userParams)
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var userFromRepo = await _serv.Get(currentUserId);

            userParams.UserId = currentUserId;

            if (string.IsNullOrEmpty(userParams.Gender))
            {
                // userParams.Gender = userFromRepo.Gender == "male" ? "female" : "male";
            }

            var users = await _serv.Get();

            var usersToReturn = _mapper.Map<IEnumerable<UserListDto>>(users);

            // Response.AddPagination(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);

            return Ok(usersToReturn);
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _serv.Get(id);

            var userToReturn = _mapper.Map<UserDetailsDto>(user);

            return Ok(userToReturn);
        }

        [HttpPut("{id}")]
        public async void UpdateUser(int id, UserDto userDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();

            var user = await _serv.Get(id);

            _mapper.Map(userDto, user);

            _serv.Update(user);

            // if (await _repo.SaveAll())
            //     return NoContent();

            // throw new Exception($"Updating user {id} failed on save");
        }

        [HttpPost("{id}")]
        public async void CreateUser(int id, UserDto userDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();

            var user = await _serv.Get(id);

            _mapper.Map(userDto, user);

            _serv.Add(user);

            // if (await _repo.SaveAll())
            //     return NoContent();

            // throw new Exception($"Updating user {id} failed on save");
        }

        [HttpDelete("{id}")]
        public async void DeleteUser(int id, UserDto userDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();

            var user = await _serv.Get(id);

            _mapper.Map(userDto, user);

            _serv.Delete(user);

            // if (await _repo.SaveAll())
            //     return NoContent();

            // throw new Exception($"Updating user {id} failed on save");
        }
    }
}