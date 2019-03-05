using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Dtos.Products
{
    public class ProductListDto
    {
        public int ProductType_Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Material { get; set; }
    }
}
