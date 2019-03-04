namespace WebAPI.Data.Models
{
    public class Check
    {
        public int Id { get; set; } 
        public bool IsConfirmationRequired { get; set; } 
        public bool IsDeliveryReuired { get; set; } 
        public bool IsDeliveryOffered { get; set; } 
        public bool IsDeliveryFree { get; set; } 
        public bool IsInsuranceRequired { get; set; } 
        public bool IsInsuranceOffered { get; set; } 
        public bool IsInsuranceFree { get; set; } 
        public bool IsAssemblyRequired { get; set; } 
        public bool IsAssemblyOffered { get; set; } 
        public bool IsAssemblyFree { get; set; } 
        public bool IsServiceRequired { get; set; } 
        public bool IsProductRequired { get; set; } 
        public bool IsCodeRequired { get; set; } 
        public bool IsActive { get; set; } 
        public bool IsFeatured { get; set; } 
        public bool IsPremium { get; set; } 
    }
}