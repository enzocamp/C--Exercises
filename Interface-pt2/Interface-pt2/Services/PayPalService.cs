using Interface_pt2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_pt2.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        const double monthlyInterest = 1.0;
        const double paymentFee = 1.02;

        List<double> installments = new List<double>();
        public List<double> CalculateInstallments(int months, double amount)
        {

            double baseCost = 0.0;
            double valueInstallment = (amount / months);

            for (int i = 1; i <= months; i++)
            {     
                baseCost = valueInstallment * (monthlyInterest * i) / 100;
                baseCost += valueInstallment;
                baseCost *= paymentFee;
                installments.Add(baseCost);
            }
            return installments;
        }

       /*public List<double> CalculateInstallments(int months, double amount)
        {

            double baseCost = 0.0;
            double valueInstallment = amount / months;

            for (int i = 1; i <= months; i++)
            {
                double monthlyPercent = i * monthlyInterest;

                baseCost = (valueInstallment * monthlyPercent) / 100 ;

                baseCost /= 100;

                baseCost += valueInstallment;

                baseCost *= paymentFee;  

                installments.Add(baseCost);
               
            }
            return installments;
        }*/
    }
} 
