using Interface_pt2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_pt2.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void GenerateContract(Contract contract, int months) 
        {
            List<double> installments = _onlinePaymentService.CalculateInstallments(months, contract.Balance);
            {
                for (int i = 0; i < months; i++)
                {
                    contract.Installments.Add(new Installment(contract.Date.AddMonths(i + 1), contract, installments[i]));
                }
            }
        }
    }
}
