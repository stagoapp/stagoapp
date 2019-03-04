using System;

namespace WebAPI.Data.Models
{
    public class Transaction : Entity
    {
        public int User_Id { get; set; } 
        public int Status_Id { get; set; } 
        public int OrderPackage_Id { get; set; } 
        public int ContactBilling_Id { get; set; } 
        public int ContactShipping_Id { get; set; } 
        public decimal Price { get; set; } 
        public string Currency { get; set; } 
        public string DataKey { get; set; } 
        public bool IsSuccessful { get; set; } 
        public DateTime DateCompleted { get; set; }        
    }
}