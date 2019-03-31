using System;
using System.Collections;
using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class OrderPackageDto : Dto
    {
        public int User { get; set; } 
        public string Status { get; set; }
        public Dictionary<string, ICollection<DateTime>> Timeline { get; set; }
        public Dictionary<string, ICollection<decimal>> Price { get; set; }
        public Dictionary<string, ICollection<OrderDto>> Orders { get; set; }
        public string PublicId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsCompleted { get; set; }
    }
}