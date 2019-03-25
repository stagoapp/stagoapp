using WebAPI.Data.Dtos;

namespace WebAPI.Data.Models
{
    public class ContactDTO : Dto
    {
        public int User_Id { get; set; } 
        public int Status_Id { get; set; } 
         public int ContactType_Id { get; set; }
         public int LocationType_Id { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }
         public string Email { get; set; }
         public int PhoneAreaCode { get; set; }
         public int Extension { get; set; }
         public string Phone { get; set; }
         public string PhoneAdditional { get; set; }
         public string Address { get; set; }
         public string Unit { get; set; }
         public string Buzzer { get; set; }
         public string PostalCode { get; set; }
         public string City { get; set; }
         public string Province { get; set; }
         public string Country { get; set; }
         public string CountryCode { get; set; }
         public string Notes { get; set; }
         public bool IsMain { get; set; }
         public bool IsFavourite { get; set; }
    }
}