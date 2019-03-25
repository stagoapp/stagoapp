using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Data.Dtos;
using WebAPI.Data.Models;
using WebAPI.Data.Repositories;

namespace WebAPI.Services
{
    public class ServiceService : EntityService<Service, ServiceDto>
    {
        public ServiceService(IEntityRepository<Service> repo, IMapper mapper) : base(repo, mapper)
        {
        }
    }
}
