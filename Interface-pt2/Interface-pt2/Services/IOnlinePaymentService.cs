using Interface_pt2.Entities;

namespace Interface_pt2.Services
{
    internal interface IOnlinePaymentService
    {
        List<double> CalculateInstallments(int months, double amount);
    }
}
