using System.ComponentModel.DataAnnotations;

namespace Loan_Management_System.Models
{
    public class LoanType
    {
        [Key]
        public string Type { get; set; }

        [Required]
        public string InterestRate { get; set; }
    }
}
