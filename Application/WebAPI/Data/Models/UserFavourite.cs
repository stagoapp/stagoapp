namespace WebAPI.Data.Models
{
    public class UserFavourite : Entity
    {
        public int User_Id { get; set; }         
        public int Object_Id { get; set; } 
        public int Entity_Id { get; set; } 
        public int Status_Id { get; set; } 
    }
}