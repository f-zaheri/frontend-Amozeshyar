namespace Amozeshyar.Database
{
    public class PreRegisteration : DBObject
    {
        public Intern Intern { get; set; }
        public int InternId { get; set; }
        public Field Field { get; set; }
        public int FieldId { get; set; }
        public StatusType Status { get; set; }
    }
    public enum StatusType{
        WaitingForPrePay,
        PrePaid,
        Canceled,
        Registred
    }
}