using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class PriceDto : Dto
    {
        public Entity Object { get; set; }
        public EntityType EntityType { get; set; }
        public Status Status { get; set; } 
        public UnitType UnitType { get; set; } 
        public SaleType SaleType { get; set; } 
        public decimal PriceInitial { get; set; }
        public decimal PriceDelivery { get; set; }
        public decimal PriceInsurance { get; set; }
        public decimal PriceInstallation { get; set; }
        public decimal PriceTax { get; set; } 
        public decimal PriceFees { get; set; } 
        public decimal PriceTotal { get; set; } 
        public decimal PriceDiscount { get; set; } 
        public decimal PriceMinimum { get; set; } 
        public decimal PriceMaximum { get; set; } 
        public int AmountMinimum { get; set; } 
        public int AmountMaximum { get; set; } 
        public string Currency { get; set; } 
        public string Description { get; set; } 
    }
}