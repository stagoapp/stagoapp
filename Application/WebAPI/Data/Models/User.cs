using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Models
{
    public class User : Entity
    {
        public int Status_Id { get; set; } 
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Username { get; set; }
        public string PublicName { get; set; }
        public string Biography { get; set; }
        public string Gender { get; set; }
        public string Requesting { get; set; }
        public string Offering { get; set; }
        public int Points { get; set; }
        public int Rating { get; set; }
        public bool IsActive { get; set; }
        public bool IsCorp { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateLastActive { get; set; }
        // ICollection
    }
}