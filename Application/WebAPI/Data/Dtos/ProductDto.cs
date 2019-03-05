using System;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class ProductDto : Dto
    {
        public ProductType ProductType{ get; set;}
        public User User { get; set; } 
        public Status Status { get; set; } 
        public Check Check { get; set; }         
        public int Stock { get; set;}
        public Guid PublicId { get; set;}
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