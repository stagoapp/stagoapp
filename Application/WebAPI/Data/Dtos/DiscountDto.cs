using System;
using WebAPI.Data.Dtos;

namespace WebAPI.Data.Dtos
{
    public class DiscountDto : Dto
    {
        public int User_Id { get; set; } 
        public int Status_Id { get; set; } 
        public int Object_Id { get; set; }
        public int EntityType_Id { get; set; }
        public int Amount { get; set; }
        public decimal Percentage { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}