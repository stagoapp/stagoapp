using System;

namespace WebAPI.Data.Models
{
    public class Timeline : Entity
    {
        public int Object_Id { get; set; }
        public int EntityType_Id { get; set; } 
        public DateTime DateRequested { get; set; } 
        public DateTime DateConfirmed { get; set; } 
        public DateTime DateShipped { get; set; } 
        public DateTime DateExpected { get; set; } 
        public DateTime DateReceived { get; set; } 
        public DateTime DateCompleted { get; set; } 
        public DateTime DateLastUsed { get; set; } 
    }
}