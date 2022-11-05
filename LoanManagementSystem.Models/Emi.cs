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
            Emipayments = new List<EmiPayment>();
        }

        public Emi(LoanApplication application)
        {
            LoanType = application.LoanType;
            Cust = application.Cust;
            Interest = application.LoanType.InterestRate;
            Amount = application.Amount;
        }

        [Key]
        public int Emiid { get; set; }

        [Required]
        public int? Amount { get; set; }
        public LoanType LoanType { get; set; }
        public float Interest { get; set; }

        public virtual CustomerInfo Cust { get; set; }
        public virtual List<EmiPayment> Emipayments { get; set; }
    }
}
