using WebAPI.Data.Dtos;
using WebAPI.Data.Models;

namespace WebAPI.Controllers
{
    public class TestController<T, D> : EntityController<T, D>
        where T : Entity
        where D : Dto
    {
        
    }
}