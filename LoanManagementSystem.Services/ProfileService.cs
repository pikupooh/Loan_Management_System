using LoanManagementSystem.Data;
using LoanManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSystem.Services
{
    public class ProfileService
    {
        private readonly ProfileService profileService;

        public ProfileService()
        {
            profileService = new ProfileService();
        }

        public CustomerInfo GetProfileById(int id)
        {
            CustomerInfo profile = profileService.GetProfileById(id);
            return profile;
        }

        public List<CustomerInfo> GetAllProfile()
        {
            List<CustomerInfo> profileList = profileService.GetAllProfile();
            return profileList;
        }
    }
}
