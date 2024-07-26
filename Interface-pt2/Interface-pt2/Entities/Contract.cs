namespace Interface_pt2.Entities
{
    internal class Contract
    {
        public DateTime Date { get; set; }
        public int ContractNumber { get; set; }
        public double Balance { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(DateTime date, int contractNumber, double balance) 
        {
            this.Date = date;   
            this.ContractNumber = contractNumber;
            this.Balance = balance;
        }

    }
}
