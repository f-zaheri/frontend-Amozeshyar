namespace Amozeshyar.Database
{
    public class Register : DBObject    
    {
        public Intern Intern { get; set; }
        public int InternId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
        public string Status { get; set; }
    }
    public enum RegisterStatus{
        FinancialProblem,
        Forbided,
        Normal
    }
}