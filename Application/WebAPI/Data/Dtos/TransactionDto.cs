using System;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class TransactionDto : Dto
    {
        public User User { get; set; } 
        public Status Status { get; set; } 
        public OrderPackage OrderPackage { get; set; } 
        public ContactDTO ContactBilling { get; set; } 
        public ContactDTO ContactShipping { get; set; } 
        public decimal Price { get; set; } 
        public string Currency { get; set; } 
        public string DataKey { get; set; } 
        public bool IsSuccessful { get; set; } 
        public DateTime DateCompleted { get; set; }        
    }
}