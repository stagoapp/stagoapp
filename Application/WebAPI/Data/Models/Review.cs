namespace WebAPI.Data.Models
{
    public class Review : Entity
    {
        public int Status_Id { get; set; } 
        public int User_Id { get; set; } 
        public int UserReceiving_Id { get; set; } 
        public int Object_Id { get; set; } 
        public int EntityType_Id { get; set; } 
        public int Order_Id { get; set; } 
        public int OrderPackage_Id { get; set; } 
        public int Rating { get; set; } 
        public string Title { get; set; } 
        public string Content { get; set; } 
        public bool IsComplaint { get; set; } 
        public bool IsResolved { get; set; } 
    }
}