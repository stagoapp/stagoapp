using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Dtos.Orders
{
    public class OrdersDetailDto
    {
        
    }
    
    public class OrderUpdateDto: OrdersDetailDto
    {
        public OrderUpdateDto()
        {
           // ModifiedDate = DateTime.Now;
            //ModifiedBy =currentUserId
        }
    }

    public class OrderCreateDto : OrdersDetailDto
    {
        public OrderCreateDto()
        {
            //DateCreated = DateTime.Now;
            //CreatedBy =currentUserId
        }
    }
}
