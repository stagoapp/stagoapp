
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace WebAPI.Data.Models
{
    public class Entity
    {
        public int Id { get; set; } 
        public DateTime DateCreated { get; set; } 
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; } 
        public int ModifiedBy { get; set; }
    }
}