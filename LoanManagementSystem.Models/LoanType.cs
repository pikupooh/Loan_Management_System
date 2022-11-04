using System.ComponentModel.DataAnnotations;

namespace LoanManagementSystem.Models
{
    public class LoanType
    {
        [Key]
        public string Type { get; set; }

        [Required]
        public string InterestRate { get; set; }
    }
}
