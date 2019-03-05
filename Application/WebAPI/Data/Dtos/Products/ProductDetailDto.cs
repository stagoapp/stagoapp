﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Dtos.Products
{
    public class ProductDetailDto
    {
        public int ProductType_Id { get; set; }
        public int User_Id { get; set; }
        public int Status_Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Dimensions { get; set; }
        public string DimensionsPackage { get; set; }
        public string Weight { get; set; }
        public string WeightPackage { get; set; }
        public string Colour { get; set; }
        public string Material { get; set; }
        public string Code { get; set; }
        public int Stock { get; set; }
        public bool IsForSale { get; set; }
        public bool IsRental { get; set; }
        public bool IsNew { get; set; }
        public bool IsConfirmationRequired { get; set; }
        public bool IsDeliveryReuired { get; set; }
        public bool IsDeliveryAvailable { get; set; }
        public bool IsDeliveryFree { get; set; }
        public bool IsAssemblyRequired { get; set; }
        public bool IsAssemblyOffered { get; set; }
        public bool IsAssemblyFree { get; set; }
        public bool IsInsuranceRequired { get; set; }
        public bool IsInsuranceOffered { get; set; }
        public bool IsInsuranceFree { get; set; }
        public bool IsServiceRequired { get; set; }
        public bool IsCodeRequired { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
    }
    
    public class ProductUpdateDto: ProductDetailDto
    {
        public ProductUpdateDto()
        {
            ModifiedDate = DateTime.Now;
            //ModifiedBy =currentUserId
        }
    }

    public class ProductCreateDto : ProductDetailDto
    {
        public ProductCreateDto()
        {
            DateCreated = DateTime.Now;
            //CreatedBy =currentUserId
        }
    }
}