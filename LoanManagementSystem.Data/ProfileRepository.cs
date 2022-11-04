using LoanManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSystem.Data
{
    public class ProfileRepository
    {

        LMSContext _dbcontext = new LMSContext();
        public List<Models.CustomerInfo> GetAllProfile()
        {
            return _dbcontext.CustomerInfos.ToList();
        }

        public Models.CustomerInfo GetProfileById(int id)
        {
            return _dbcontext.CustomerInfos.Find(id);
        }
    }
}
