using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Models
{
    public class Service : Entity
    {
        public int ServiceType_Id { get; set; }
        public int User_Id { get; set; }
        public int Status_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Keywords { get; set; }
        public bool IsCodeRequired { get; set; }
        public bool IsProductRequired { get; set; }
        public bool IsConfirmationRequired { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
    }
}