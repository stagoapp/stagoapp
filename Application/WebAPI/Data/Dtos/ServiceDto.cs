using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class ServiceDto : Dto
    {
        public User User { get; set; } 
        public ServiceType ServiceType { get; set; }
        public Status Status { get; set; } 
        public Check Check { get; set; } 
        public Guid PublicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public ICollection<string> Keywords { get; set; }
    }
}