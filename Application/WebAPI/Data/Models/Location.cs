using System;

namespace WebAPI.Data.Models
{
    public class Location : Entity
    {
        public int LocationType_Id { get; set; }
        public int Contact_Id { get; set; }
        public int Status_Id { get; set; }
        public int Price_Id { get; set; }
        public int Rooms { get; set; }        
        public int Living { get; set; }
        public int Dining { get; set; }
        public int Kitchen { get; set; }
        public int Bedrooms { get; set; }
        public int Stories { get; set; }
        public int Balcony { get; set; }
        public int Backyard { get; set; }
        public Guid PublicId { get; set; }
        public string MLSId { get; set; }
        public string Size { get; set; }
        public string EntranceSize { get; set; }
        public string Description { get; set; }
        public bool IsRenovated { get; set; }
        public bool IsTenant { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsElevatorRequired { get; set; }
        public bool IsMain { get; set; }
        public bool IsFavourite { get; set; }
        public DateTime DateBuilt { get; set; }
    }
}