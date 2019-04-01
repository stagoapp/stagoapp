using WebAPI.Data.Models;
using WebAPI.Data.Dtos;

namespace WebAPI.Services
{
    public interface IUserService<User, UserDto>: 
                        IEntityService<Entity, Dto>
    {

    }
}