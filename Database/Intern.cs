using System.Collections.Generic;

namespace Amozeshyar.Database
{
    public class Intern : DBObject, IPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public ICollection<PreRegisteration> PreRegisterations { get; set; }
        public ICollection<FinancialTransaction> FinancialTransactions { get; set; }
        public ICollection<Register> Registers { get; set; }
    }
}