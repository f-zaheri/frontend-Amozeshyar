namespace Amozeshyar.Database
{
    public class FinancialTransaction : DBObject
    {
        public Intern Intern { get; set; }
        public int InternId { get; set; }
        public double DebtAmount { get; set; }
        public double CreditAmount { get; set; }
        public string About { get; set; }
    }
}