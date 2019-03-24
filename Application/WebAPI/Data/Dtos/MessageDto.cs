using System;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class MessageDto : Dto
    {
        public Status Status { get; set; } 
        public User User { get; set; } 
        public User UserReceiving { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime DateRead { get; set; }
    }
}