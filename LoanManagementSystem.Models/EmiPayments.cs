using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

#nullable disable

namespace LoanManagementSystem.Models
{
    public partial class Emipayment
    {
        [Key]
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ReceiptDate { get; set; }
        public int? Emiid { get; set; }
        public DateTime? IssueDate { get; set; }
        public decimal? Emiamount { get; set; }
        public decimal? LastPaid { get; set; }
        public decimal? Fine { get; set; }
        public virtual Emi Emi { get; set; }
    }
}
