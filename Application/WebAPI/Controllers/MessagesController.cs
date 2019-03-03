using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.Data.Dtos;
using WebAPI.Helpers;
using WebAPI.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data.Repositories;

namespace WebAPI.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Authorize]
    [Route("api/users/{userId}/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        // private readonly IOrderRepository _repo;
        private readonly IRepository<Message> _repo;
        private readonly IMapper _mapper;
        public MessagesController(IRepository<Message> repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet("{id}", Name = "GetMessage")]
        public async Task<IActionResult> GetMessage(int userId, int id)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var messageFromRepo = await _repo.Get(id);

            if (messageFromRepo == null)
                return NotFound();

            return Ok(messageFromRepo);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetMessagesForUser(int userId, 
            [FromQuery]MessageParams messageParams)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            messageParams.UserId = userId;

            // var messagesFromRepo = await _repo.Get(messageParams);
            // var messages = _mapper.Map<IEnumerable<MessageToReturnDto>>(messagesFromRepo);
            // Response.AddPagination(messagesFromRepo.CurrentPage, messagesFromRepo.PageSize, 
            //     messagesFromRepo.TotalCount, messagesFromRepo.TotalPages);            
            // return Ok(messages);

            return Ok();
        }

        [HttpGet("thread/{recipientId}")]
        public async Task<IActionResult> GetMessageThread(int userId, int recipientId)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            // var messagesFromRepo = await _repo.Get(userId, recipientId);
            // var messageThread = _mapper.Map<IEnumerable<MessageToReturnDto>>(messagesFromRepo);
            // return Ok(messageThread);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(int userId, MessageForCreationDto messageForCreationDto)
        {
            var sender = await _repo.Get(userId);

            if (sender.Id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            messageForCreationDto.SenderId = userId;

            var recipient = await _repo.Get(messageForCreationDto.RecipientId);

            if (recipient == null)
                return BadRequest("Could not find user");
            
            var message = _mapper.Map<Message>(messageForCreationDto);

            _repo.Add(message);

            // if (await _repo.Update())
            // {
            //     var messageToReturn = _mapper.Map<MessageToReturnDto>(message);
            //     return CreatedAtRoute("GetMessage", new {id = message.Id}, messageToReturn);
            // }

            throw new Exception("Creating the message failed on save");
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> DeleteMessage(int id, int userId)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();  

            var messageFromRepo = await _repo.Get(id);

            // if (messageFromRepo.UserSending_Id == userId)
            //     messageFromRepo.SenderDeleted = true;

            // if (messageFromRepo.UserReceiving_Id == userId)
            //     messageFromRepo.RecipientDeleted = true;

            // if (messageFromRepo.SenderDeleted && messageFromRepo.RecipientDeleted)
            //     _repo.Delete(messageFromRepo);
            
            // if (await _repo.Update())
            //     return NoContent();

            throw new Exception("Error deleting the message");
        }

        [HttpPost("{id}/read")]
        public async Task<IActionResult> MarkMessageAsRead(int userId, int id)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();  

            var message = await _repo.Get(id);

            if (message.UserReceiving_Id != userId)
                return Unauthorized();

            message.IsRead = true;
            message.DateRead = DateTime.Now;

            // await _repo.Update();

            return NoContent();
        }
    }
}