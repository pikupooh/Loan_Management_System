using LoanManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace Loan_Management_System.Models
{
    public class LoanApplications
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public string CustomerID { get; set; }

        public BankDetails BankDetails { get; set; }
    }
}
