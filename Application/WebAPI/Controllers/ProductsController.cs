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
    public class ProductsController : EntityController<Product, ProductDto>
    {


     

        public ProductsController()
        {
           
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery]ProductParams ProductParams)
        {
            
            var products = await Get();

            // Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalCount, products.TotalPages);

            return Ok(products);
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await Get(id);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async void UpdateProduct(int id, ProductUpdateDto productForUpdateDto)
        {
           
            var productFromRepo = await Get(id);
            Update(productFromRepo);
        }

        [HttpPut]
        public async Task<IActionResult> CreateProduct(ProductCreateDto productForCreateDto)
        {
            ProductDto product = new ProductDto();
            Add(product);
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
            var product = await Get(id);
            Delete(product);
            return Ok();
        }

    }
}
