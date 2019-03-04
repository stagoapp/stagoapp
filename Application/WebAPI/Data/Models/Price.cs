namespace WebAPI.Data.Models
{
    public class Price : Entity
    {
        public int Object_Id { get; set; }
        public int EntityType_Id { get; set; }
        public int Status_Id { get; set; } 
        public int UnitType_Id { get; set; } 
        public int SaleType_Id { get; set; } 
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