using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable
namespace LoanManagementSystem.Models
{
    public partial class BankDetail
    {
        public string BankName { get; set; }
        public string BankAddress { get; set; }
    }
}
