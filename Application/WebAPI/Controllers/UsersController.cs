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

        public UsersController(IUserService<User, UserDto> serv)
        {
            _serv = serv;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _serv.Get(id);
            return Ok(user);
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
            // Response.AddPagination(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);
            return Ok(users);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            var userFromRepo = await _serv.Get(currentUserId);
            var users = await _serv.Get();
            // Response.AddPagination(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);
            return Ok(users);
        }
        
        [HttpPost("{id}")]
        public async void CreateUser(UserDto userDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();
            _serv.Add(userDto);
            // if (await _repo.SaveAll())
            //     return NoContent();
            // throw new Exception($"Updating user {id} failed on save");
        }

        [HttpPost("{id}")]
        public async void CreateUsers(IEnumerable<UserDto> userDtos)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();
            _serv.Add(userDtos);
            // if (await _repo.SaveAll())
            //     return NoContent();
            // throw new Exception($"Updating user {id} failed on save");
        }

        [HttpPut("{id}")]
        public async void UpdateUser(UserDto userDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();
            _serv.Update(userDto);
            // if (await _repo.SaveAll())
            //     return NoContent();
            // throw new Exception($"Updating user {id} failed on save");
        }

        [HttpPut("{id}")]
        public async void UpdateUsers(IEnumerable<UserDto> userDtos)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();
            _serv.Update(userDtos);
            // if (await _repo.SaveAll())
            //     return NoContent();
            // throw new Exception($"Updating user {id} failed on save");
        }


        [HttpDelete("{id}")]
        public async void DeleteUser(int id)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();
            var user = await _serv.Get(id);
            _serv.Delete(user);
            // if (await _repo.SaveAll())
            //     return NoContent();
            // throw new Exception($"Updating user {id} failed on save");
        }

        [HttpDelete("{id}")]
        public async void DeleteUsers(UserDto userDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();
            var user = await _serv.Get(userDto.Id);
            _serv.Delete(userDto);
            // if (await _repo.SaveAll())
            //     return NoContent();
            // throw new Exception($"Updating user {id} failed on save");
        }

        [HttpDelete("{id}")]
        public async void DeleteAllUsers(IEnumerable<UserDto> users)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();
            _serv.Delete(users);
            // if (await _repo.SaveAll())
            //     return NoContent();
            // throw new Exception($"Updating user {id} failed on save");
        }
    }
}