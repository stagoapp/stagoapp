namespace WebAPI.Data.Models
{
    public class Account : Entity
    {
         public int User_Id { get; set; }
         public int Status_Id { get; set; }
         public int AccountNumber { get; set; }
         public int BranchNumber { get; set; }
         public int BankNumber { get; set; }
    }
}