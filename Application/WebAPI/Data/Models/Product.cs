using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Models
{
    public class Product : Entity
    {
        public int ProductType_Id { get; set;}
        public int User_Id { get; set; } 
        public int Status_Id { get; set; } 
        public int Check_Id { get; set; }         
        public int Stock { get; set;}
        public string Name { get; set;}
        public string Description { get; set;}
        public string Dimensions { get; set;}
        public string DimensionsPackage { get; set;}
        public string Weight { get; set;}
        public string WeightPackage { get; set;}
        public string Colour { get; set;}
        public string Material { get; set;}
        public string Code { get; set;}
        public string Category { get; set;}
        public string Keywords { get; set;}
    }
}