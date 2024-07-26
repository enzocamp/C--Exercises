using System.Globalization;
using Interface_pt2.Entities;
using Interface_pt2.Services;

namespace Interface_pt2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date: (dd/MM/yyyy) ");
            //string stringDate = Console.ReadLine();
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installment: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractDate, contractNumber,value);

            ContractService contractService = new ContractService(new PayPalService());

            contractService.GenerateContract(contract, months);

            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}