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
using WebAPI.Data.Dtos.Services;

namespace WebAPI.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : EntityController<Service, ServiceDto>
    {
        
        

            public ServicesController()
            {

            }

            [HttpGet]
            public async Task<IActionResult> GetServices([FromQuery]ServiceParams ServiceParams)
            {

                var orders = await Get();

                // Response.AddPagination(orders.CurrentPage, orders.PageSize, orders.TotalCount, orders.TotalPages);

                return Ok(orders);
            }

            [HttpGet("{id}", Name = "GetService")]
            public async Task<IActionResult> GetService(int id)
            {
                var order = await Get(id);
                return Ok(order);
            }

            [HttpPut("{id}")]
            public async void UpdateService(int id, ServiceUpdateDto orderForUpdateDto)
            {

                var orderFromRepo = await Get(id);
                Update(orderFromRepo);
            }

            [HttpPut]
            public async Task<IActionResult> CreateService(ServiceCreateDto orderForCreateDto)
            {
                ServiceDto order = new ServiceDto();
                Add(order);
                if (order.Id > 0)
                {
                    return Ok();
                }
                else
                {
                    return NoContent();
                }
            }
            [HttpPut("{id}")]
            public async Task<IActionResult> DeleteService(int id)
            {
                var order = await Get(id);
                Delete(order);
                return Ok();
            }
        }
}