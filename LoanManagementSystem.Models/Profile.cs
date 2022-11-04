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

        [Display(Name = "Email address:")]
        [Required(ErrorMessage = "The email address is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Display(Name = "PAN Card:")]
        [Required(ErrorMessage = "PAN Number is required")]
        [RegularExpression("^([A-Za-z]){5}([0-9]){4}([A-Za-z]){1}$", ErrorMessage = "Invalid PAN Number")]
        public string PAN { get; set; }

        [Display(Name = "Phone Number:")]
        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression("^([0-9]){10}$", ErrorMessage = "Invalid Phone Number")]
        public int PhoneNumber { get; set; }
        
        public string Address { get; set; }

        public List<Emi> Emis { get; set; }
        public List<LoanApplications> LoanApplications { get; set; }
    }
}
