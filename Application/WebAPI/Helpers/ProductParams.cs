using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Helpers
{
    public class ProductParams
    {

        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
        public string OrderBy { get; set; }

        public List<int> ProductType_Id { get; set; }
        public List<int> User_Id { get; set; }
        public List<int> Status_Id { get; set; }
        public List<string> Category { get; set; }
        public List<string> Name { get; set; }        
        public string Keywords { get; set; }
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
    }
}
