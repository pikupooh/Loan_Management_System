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
        ProfileRepository _repository = new ProfileRepository();
        public CustomerInfo GetProfileById(int id)
        {
            return _repository.GetProfileById(id);
        }

        public List<CustomerInfo> GetAllProfile()
        {
            return _repository.GetAllProfile();
        }
    }
}
