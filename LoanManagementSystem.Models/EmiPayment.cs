using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

#nullable disable

namespace LoanManagementSystem.Models
{
    public partial class EmiPayment
    {
        [Key]
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? IssueDate { get; set; }
        public decimal? Emiamount { get; set; }
        public DateTime? PiadOn { get; set; }
        public decimal? Fine { get; set; }
        public virtual Emi Emi { get; set; }
    }
}
