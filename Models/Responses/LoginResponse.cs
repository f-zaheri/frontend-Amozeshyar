namespace Amozeshyar.Models.Responses
{
    public class LoginResponse
    {
        public bool IsAthenticated { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}