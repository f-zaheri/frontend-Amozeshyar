namespace Amozeshyar.Database
{
    public interface IPerson
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Gender { get; set; }
        string Mobile { get; set; }
        string Address { get; set; }
        public string Password { get; set; }  
    }
}