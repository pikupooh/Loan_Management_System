using LoanManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loan_Management_System.Models
{
    public class Emi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Amount { get; set; }

        public int CustomerID { get; set; }

        public LoanType LoanType { get; set; }
        public List<EmiPayments> EmiPayments { get; set; }

        public BankDetails BankDetails { get; set; }
    }
}
