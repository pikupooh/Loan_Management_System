using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loan_Management_System.Models
{
    public class Emi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Amount { get; set; }

        public string CustomerID { get; set; }
    }
}
