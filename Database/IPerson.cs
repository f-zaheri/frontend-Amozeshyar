namespace Amozeshyar.Database
{
    public interface IPerson
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Gender { get; set; }
        string Mobile { get; set; }
        string Address { get; set; }
        string Password { get; set; }  
        byte[] Salt { get; set; }
        string Role { get; }
    }
}