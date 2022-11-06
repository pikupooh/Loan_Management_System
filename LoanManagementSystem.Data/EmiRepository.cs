using LoanManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace LoanManagementSystem.Data
{
    public class EmiRepository:BaseRepository
    {
        public List<Emi> GetAllEMIs()
        {
            return _dbcontext.Emis.Include(emi => emi.Emipayments).Include(emi => emi.Cust).ToList();
        }

        public Models.Emi GetEMIById(int id)
        {
            return _dbcontext.Emis.Include(emi => emi.Emipayments).Include(emi => emi.Cust).First(emi => emi.Emiid == id);
        }

        public List<Emi> GetEMIByCustId(int id)
        {
            return _dbcontext.Emis.Include(emi => emi.Emipayments).Include(emi => emi.Cust).Where(emi => emi.Cust.Custid == id).ToList(); 
        }

    }
}
