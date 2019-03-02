using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Models
{
    public class Message : Entity
    {
        public int UserSending_Id { get; set; }
        public int UserReceiving_Id { get; set; }
        public int Status_Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime DateRead { get; set; }
        public DateTime DateSent { get; set; }
    }
}