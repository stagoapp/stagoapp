using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class ReviewDto : Dto
    {
        public Status Status{ get; set; } 
        public User User{ get; set; } 
        public User UserReceiving { get; set; } 
        public Entity Object { get; set; } 
        public EntityType EntityType { get; set; } 
        public Order Order { get; set; } 
        public OrderPackage OrderPackage { get; set; } 
        public int Rating { get; set; } 
        public string Title { get; set; } 
        public string Content { get; set; } 
        public bool IsComplaint { get; set; } 
        public bool IsResolved { get; set; } 
    }
}