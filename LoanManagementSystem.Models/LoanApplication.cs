﻿using LoanManagementSystem.Models;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

#nullable disable
namespace LoanManagementSystem.Models
{
    public enum LoanStatus
    { 
        APPLIED, 
        ACCEPTED,
        DECLINED
    }

    public partial class LoanApplication
    {
        [Key]
        public int AppId { get; set; }
        public LoanType LoanType { get; set; }
        public virtual CustomerInfo Cust { get; set; }
        public LoanStatus status { get; set; }
        public int Amount { get; set; }
    }
}
