using System;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class OrderDto : Dto
    {
        public Entity Object { get; set; }
        public EntityType EntityType { get; set; }
        public Service ServiceDelivery { get; set; }
        public Service ServiceInstallation { get; set; }
        public Service ServiceInsurance { get; set; }
        public OrderPackage OrderPackage{ get; set; }
        public User User { get; set; } 
        public User UserOffering { get; set; }
        public Contact Contact { get; set; }
        public Price Price { get; set; }
        public Discount Discount { get; set; }
        public Status Status { get; set; } 
        public Timeline Timeline { get; set; }
        public int Amount { get; set; }
        public Guid PublicId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsRent { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsCompleted { get; set; }
    }
}