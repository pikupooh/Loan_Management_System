using System.ComponentModel.DataAnnotations;

namespace LoanManagementSystem.Models
{
    public class EmiPayments
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReceiptDate { get; set; }

        public int EmiID { get; set; }

    }
}
