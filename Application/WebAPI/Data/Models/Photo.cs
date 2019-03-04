using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Models
{
    public class Photo : Entity
    {
        public int Status_Id { get; set; } 
        public int Object_Id { get; set; }
        public int EntityType_Id { get; set; }
        public int Index { get; set; }
        public string Url { get; set; }
        public string UrlPublic { get; set; }
        public string Description { get; set; }
        public bool IsMain { get; set; }
    }
}