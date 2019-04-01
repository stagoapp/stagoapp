using WebAPI.Data.Models;
using WebAPI.Data.Dtos;
using AutoMapper;
using WebAPI.Data.Repositories;

namespace WebAPI.Services
{
    public class UserService<User, UserDto> : 
                    EntityService<Entity, Dto>, 
                    IUserService<User, UserDto>
    {
        public UserService(IEntityRepository<Entity> repo, IMapper mapper) : 
                            base(repo, mapper)
        {
        }
    }
}