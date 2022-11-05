using LoanManagementSystem.Data;
using LoanManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanManagementSystem.Services
{
    public class EmiPaymentService
    {
        private readonly EmiPaymentRepository emiPaymentRepository;

        public EmiPaymentService()
        {
            emiPaymentRepository = new EmiPaymentRepository();
        }

        public List<EmiPayment> GetAllPayments()
        {
            List<EmiPayment> emiPayments = emiPaymentRepository.GetAllPayments();
            return emiPayments;
        }

        public List<EmiPayment> GetPaymentsByCustomerId(int customerId)
        {
            List<EmiPayment> emiPayments = emiPaymentRepository.GetPaymentsByCustomerId(customerId);
            return emiPayments;
        }

        public EmiPayment GetPaymentByPaymentId(int paymentId)
        {
            EmiPayment emiPayment = emiPaymentRepository.GetPaymentByPaymentId(paymentId);
            return emiPayment;
        }

        public List<EmiPayment> GetPaymentsByEmiId(int EmiId)
        {
            List<EmiPayment> emiPayments = emiPaymentRepository.GetPaymentByEmiId(EmiId);
            return emiPayments;
        }

        public EmiPayment AddPayment(int emiId, int amountPaid)
        {
            EmiService emiService = new EmiService();
            Emi emi = emiService.GetEmiById(emiId);

            EmiPayment emiPayment = emiPaymentRepository.AddPayment(emi, amountPaid);
            return emiPayment;
        }
    }
}
