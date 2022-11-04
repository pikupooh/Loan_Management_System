using LoanManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

#nullable disable
namespace LoanManagementSystem.Models
{
    public partial class Emi
    {
        public Emi()
        {
            Emipayments = new HashSet<Emipayment>();
        }

        [Key]
        public int Emiid { get; set; }

        [Required]
        public decimal? Amount { get; set; }
        public int? Custid { get; set; }
        public string LoanType { get; set; }

        public virtual CustomerInfo Cust { get; set; }
        public virtual ICollection<Emipayment> Emipayments { get; set; }
    }
}
