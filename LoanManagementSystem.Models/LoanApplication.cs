using LoanManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

#nullable disable
namespace LoanManagementSystem.Models
{
    public partial class LoanApplication
    {
        public int AppId { get; set; }
        public string LoanType { get; set; }
        public int? Custid { get; set; }
        public virtual CustomerInfo Cust { get; set; }
    }
}
