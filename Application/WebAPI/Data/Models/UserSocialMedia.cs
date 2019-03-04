namespace WebAPI.Data.Models
{
    public class UserSocialMedia : Entity
    {
        public int User_Id { get; set; } 
        public int Status_Id { get; set; } 
        public string SocialMedia { get; set; } 
        public string Link { get; set; } 
    }
}