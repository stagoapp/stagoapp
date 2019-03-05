using System;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class OrderPackageDto : Dto
    {
        public User User { get; set; } 
        public Status Status { get; set; }
        public Timeline Timeline { get; set; }
        public Price Price { get; set; }
        public Guid PublicId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsCompleted { get; set; }
    }
}