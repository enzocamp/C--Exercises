using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Interface_pt2.Entities
{
    internal class Installment
    {
        public DateTime DuoDate { get; set; }
        public Contract Contract { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime duoDate, Contract contract, double amount)
        {
            DuoDate = duoDate;
            Contract = contract;
            Amount = amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DuoDate.ToString() + " - ");
            sb.Append(Amount.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();

        }
    }
}
