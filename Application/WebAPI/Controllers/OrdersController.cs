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
using WebAPI.Data.Dtos.Orders;


namespace WebAPI.Controllers

{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : EntityController<Order, OrderDto>
    {

        public OrdersController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetOrders([FromQuery]OrderParams OrderParams)
        {

            var orders = await Get();

            // Response.AddPagination(orders.CurrentPage, orders.PageSize, orders.TotalCount, orders.TotalPages);

            return Ok(orders);
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var order = await Get(id);
            return Ok(order);
        }

        [HttpPut("{id}")]
        public async void UpdateOrder(int id, OrderUpdateDto orderForUpdateDto)
        {

            var orderFromRepo = await Get(id);
            Update(orderFromRepo);
        }

        [HttpPut]
        public async Task<IActionResult> CreateOrder(OrderCreateDto orderForCreateDto)
        {
            OrderDto order = new OrderDto();
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
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await Get(id);
            Delete(order);
            return Ok();
        }

    }
}