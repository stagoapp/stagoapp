using WebAPI.Data.Models;

namespace WebAPI.Data.Dtos
{
    public class AccountDto : Dto
    {
        public User User{ get; set; } 
        public Status Status { get; set; } 
        public int AccountNumber { get; set; }
        public int BranchNumber { get; set; }
        public int BankNumber { get; set; }
    }
}