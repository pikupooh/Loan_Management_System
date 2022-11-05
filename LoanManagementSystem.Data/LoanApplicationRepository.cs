using LoanManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagementSystem.Data
{
    public class LoanApplicationRepository
    {
        LMSContext context;
        public LoanApplicationRepository()
        {
        }

        public static LoanApplication AddLoanApplication(CustomerInfo customerInfo, LoanType loanType, int loanAmount)
        {
            throw new NotImplementedException();
        }

        public void AcceptLoanApplication(int applicationId)
        {
            LoanApplication application = GetApplicationById(applicationId);
            application.status = LoanStatus.ACCEPTED;
            context.SaveChanges();
        }

        public void DeclineLoanApplication(int applicationId)
        {
            LoanApplication application = GetApplicationById(applicationId);
            application.status = LoanStatus.DECLINED;
            context.SaveChanges();
        }

        public List<LoanApplication> GetApplication()
        {
            return context.LoanApplications.ToList();
        }

        public LoanApplication GetApplicationById(int Id)
        {
            return context.LoanApplications.FirstOrDefault(application => application.AppId == Id);
        }

        public List<LoanApplication> GetApplicationsByCustomerId(int Id)
        {
            return context.LoanApplications.Include(application => application.Cust).ToList();
        }
    }
}