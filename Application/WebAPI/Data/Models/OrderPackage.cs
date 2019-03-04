using System;

namespace WebAPI.Data.Models
{
    public class OrderPackage : Entity
    {
        public int User_Id { get; set; } 
        public int Status_Id { get; set; }
        public int Timeline_Id { get; set; }
        public int Price_d { get; set; }
        public Guid PublicId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsCompleted { get; set; }
    }
}