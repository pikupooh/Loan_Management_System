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
        LMSContext _dbcontext = new LMSContext();
        public CustomerInfo GetProfileById(int id)
        {
            return null;
        }

        public List<CustomerInfo> GetAllProfile()
        {
            return _dbcontext.CustomerInfos.ToList();
        }
    }
}
