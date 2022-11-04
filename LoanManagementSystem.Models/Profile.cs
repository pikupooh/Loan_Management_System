using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Loan_Management_System.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        public string PAN { get; set; }

        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public List<Emi> Emis { get; set; }
        public List<LoanApplication> LoanApplications { get; set; }
    }
}
