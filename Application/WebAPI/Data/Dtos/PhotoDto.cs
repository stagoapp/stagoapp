using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class PhotoDto : Dto
    {
        public Status Status{ get; set; } 
        public Entity Object { get; set; }
        public EntityType EntityType { get; set; }
        public int Index { get; set; }
        public string Url { get; set; }
        public string UrlPublic { get; set; }
        public string Description { get; set; }
        public bool IsMain { get; set; }
    }
}