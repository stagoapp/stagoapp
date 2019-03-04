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

namespace WebAPI.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepository<User> _repo;
        private readonly IMapper _mapper;

        public UsersController(IRepository<User> repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery]UserParams userParams)
        {
            var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var userFromRepo = await _repo.Get(currentUserId);

            userParams.UserId = currentUserId;

            if (string.IsNullOrEmpty(userParams.Gender))
            {
                // userParams.Gender = userFromRepo.Gender == "male" ? "female" : "male";
            }

            var users = await _repo.Get();

            var usersToReturn = _mapper.Map<IEnumerable<UserListDto>>(users);

            // Response.AddPagination(users.CurrentPage, users.PageSize, users.TotalCount, users.TotalPages);

            return Ok(usersToReturn);
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.Get(id);

            var userToReturn = _mapper.Map<UserDetailsDto>(user);

            return Ok(userToReturn);
        }

        [HttpPut("{id}")]
        public async void UpdateUser(int id, UserForUpdateDto userForUpdateDto)
        {
            // if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //     return Unauthorized();

            var userFromRepo = await _repo.Get(id);

            _mapper.Map(userForUpdateDto, userFromRepo);

            _repo.Update(userFromRepo);

            // if (await _repo.SaveAll())
            //     return NoContent();

            // throw new Exception($"Updating user {id} failed on save");
        }
    }
}