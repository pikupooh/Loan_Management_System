using LoanManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace LoanManagementSystem.Models
{
    public class LoanApplication
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public string CustomerID { get; set; }

        public BankDetails BankDetails { get; set; }
    }
}
