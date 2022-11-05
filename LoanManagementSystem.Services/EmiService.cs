using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanManagementSystem.Data;
using LoanManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagementSystem.Services
{
    public class EmiService
    {
        LMSContext context;
        private readonly LoanApplicationRepository loanApplicationRepository;

        public Emi AcceptLoanApplication(int applicationId)
        {
            LoanApplication application = loanApplicationRepository.GetApplicationById(applicationId);

            if(application == null)
            {
                return null;
            }

            Emi emi = new Emi(application);
            loanApplicationRepository.AcceptLoanApplication(applicationId);
            return emi;
            
        }

        public List<Emi> GetAllLoans()
        {
            List<Emi> emis = context.Emis.Include(emi => emi.Emipayments).Include(emi => emi.Cust).ToList();
            if (emis.Any())
            {
                return emis;
            }
            return null;
        }

        public Emi GetEmiById(int loanId)
        {
            Emi emi = context.Emis.Include(emi => emi.Emipayments).Include(emi => emi.Cust).First(emi => emi.Emiid == loanId);
            return emi;
        }

        public List<Emi> GetEmisByCustomerId(int customerId)
        {
            List<Emi> emis = context.Emis.Include(emi => emi.Emipayments).Include(emi => emi.Cust).Where(emi => emi.Cust.Custid == customerId).ToList();
            if (emis.Any())
            {
                return emis;
            }
            return null;
        }

        public bool DeclineLoanApplication(int applicationId)
        {
            LoanApplication application = loanApplicationRepository.GetApplicationById(applicationId);

            loanApplicationRepository.DeclineLoanApplication(applicationId);

            return true;
        }
    }
}
