using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Models
{
    public class Order : Entity
    {
        public int Object_Id { get; set; }
        public int EntityType_Id { get; set; }
        public int ServiceDelivery_Id { get; set; }
        public int ServiceInstallation_Id { get; set; }
        public int ServiceInsurance_Id { get; set; }
        public int OrderPackage_Id { get; set; }
        public int User_Id { get; set; } 
        public int UserOffering_Id { get; set; }
        public int Contact_Id { get; set; }
        public int Price_Id { get; set; }
        public int Discount_Id { get; set; }
        public int Status_Id { get; set; } 
        public int Timeline_Id { get; set; }
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