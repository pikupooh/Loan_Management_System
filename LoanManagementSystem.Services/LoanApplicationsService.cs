using LoanManagementSystem.Data;
using LoanManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSystem.Services
{
    public class LoanApplicationsService
    {
        private LoanApplicationRepository loanApplicationRepository;

        public LoanApplicationsService()
        {
            loanApplicationRepository = new LoanApplicationRepository();
        }
        public List<LoanApplication> GetAllApllications()
        {
            List<LoanApplication> loanApplications = loanApplicationRepository.GetApplication();
            return loanApplications;
        }

        public List<LoanApplication> GetApllicationByCustomerId(int Id)
        {
            List<LoanApplication> applications = loanApplicationRepository.GetApplicationsByCustomerId(Id);
            return applications;
        }

        public LoanApplication GetApllicationByApplicationId(int Id)
        {
            LoanApplication application = loanApplicationRepository.GetApplicationById(Id);
            return application;
        }

        public LoanApplication SubmitApplication(int customerId, string loanTypeName, int loanAmount)
        {
            ProfileService profileService = new ProfileService();
            CustomerInfo customerInfo = profileService.GetProfileById(customerId);
            
            if(customerInfo == null)
            {
                return null;
            }

            LoanTypeService loanTypeService = new LoanTypeService();
            LoanType loanType = loanTypeService.GetLoanTypeByName(loanTypeName);

            if(loanType == null)
            {
                return null;
            }

            LoanApplication loanApplication = LoanApplicationRepository.AddLoanApplication(customerInfo, loanType, loanAmount);
            return loanApplication;
        }
    }
}
