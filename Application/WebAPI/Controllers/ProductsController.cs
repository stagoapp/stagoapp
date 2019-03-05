using AutoMapper;
using System;
using System.Collections.Generic;
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
using WebAPI.Data.Dtos.Products;

namespace WebAPI.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        private readonly IRepository<Product> _repo;
        private readonly IMapper _mapper;

        public ProductsController(IRepository<Product> repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery]ProductParams ProductParams)
        {
            
            var products = await _repo.Get();

            var productsToReturn = _mapper.Map<IEnumerable<ProductListDto>>(products);

            // Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalCount, products.TotalPages);

            return Ok(productsToReturn);
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _repo.Get(id);

            var productToReturn = _mapper.Map<ProductDetailDto>(product);

            return Ok(productToReturn);
        }

        [HttpPut("{id}")]
        public async void UpdateProduct(int id, ProductUpdateDto productForUpdateDto)
        {
           

            var productFromRepo = await _repo.Get(id);

            _mapper.Map(productForUpdateDto, productFromRepo);

            _repo.Update(productFromRepo);
            _repo.Save();
            // if (await _repo.SaveAll())
            //     return NoContent();

            // throw new Exception($"Updating product {id} failed on save");
        }

        [HttpPut]
        public async Task<IActionResult> CreateProduct(ProductCreateDto productForCreateDto)
        {
            Product product = new Product();
            _mapper.Map(productForCreateDto, product);
            _repo.Add(product);
            _repo.Save();
            if(product.Id>0)
            {
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var productFromRepo = await _repo.Get(id);        
            _repo.Delete(productFromRepo);
            _repo.Save();
            return Ok();
        }

    }
}
