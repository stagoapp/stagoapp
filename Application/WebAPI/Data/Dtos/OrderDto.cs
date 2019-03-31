using System;
using System.Collections;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class OrderDto : Dto
    {
        public int Object { get; set; }
        public string EntityType { get; set; }
        public Dictionary<string, ICollection<ServiceDto>> Services { get; set; }
        public int OrderPackage{ get; set; }
        public int User { get; set; } 
        public int UserOffering { get; set; }
        public Dictionary<string, ICollection<ContactDto>> Contacts { get; set; }
        public Dictionary<string, ICollection<decimal>> Prices { get; set; }
        public DiscountDto Discount { get; set; }
        public string Status { get; set; } 
        public Dictionary<string, ICollection<DateTime>> Timeline { get; set; }
        public int Amount { get; set; }
        public string PublicId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsRent { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsCompleted { get; set; }
    }
}