using LoanManagementSystem.Models;
using System;
using System.Collections.Generic;


namespace LoanManagementSystem.Data
{
    public class EmiPaymentRepository:BaseRepository
    {
        public EmiPayment AddPayment(Emi emi, int amountPaid)
        {
            EmiPayment payment = new EmiPayment();
            payment.Emi = emi;
            payment.Emiamount = amountPaid;
            _dbcontext.Add(payment);
            _dbcontext.SaveChanges();
            return payment;
        }

        public List<EmiPayment> GetAllPayments()
        {
            return _dbcontext.Emipayments.ToList();
        }

        public List<EmiPayment> GetPaymentByEmiId(int emiId)
        {
            return _dbcontext.Emipayments.Where(payment => payment.Emi.Emiid == emiId).ToList();
        }

        public EmiPayment? GetPaymentByEmiPaymentId(int paymentId)
        {
            return _dbcontext.Emipayments.Find(paymentId);
        }

        public List<EmiPayment> GetPaymentsByCustomerId(int customerId)
        {
            return _dbcontext.Emipayments.Where(emi => emi.Emi.Cust.Custid == customerId).ToList();
        }
       
    }
}
