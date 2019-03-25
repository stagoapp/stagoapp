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
    public class ProductService : EntityService<Product, ProductDto>
    {
        public ProductService(IEntityRepository<Product> repo, IMapper mapper) : base(repo, mapper)
        {
        }
    }
}
