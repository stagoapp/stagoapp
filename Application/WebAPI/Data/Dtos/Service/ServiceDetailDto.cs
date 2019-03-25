using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data.Dtos.Services
{
    public class ServicesDetailDto
    {
        
    }
    
    public class ServiceUpdateDto : ServicesDetailDto
    {
        public ServiceUpdateDto()
        {
           // ModifiedDate = DateTime.Now;
            //ModifiedBy =currentUserId
        }
    }

    public class ServiceCreateDto : ServicesDetailDto
    {
        public ServiceCreateDto()
        {
            //DateCreated = DateTime.Now;
            //CreatedBy =currentUserId
        }
    }
}
