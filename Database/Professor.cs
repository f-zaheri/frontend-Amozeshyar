using System.Collections.Generic;

namespace Amozeshyar.Database
{
    public class Professor : DBObject, IPerson
    {
        internal string password;

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Field { get; set; }
        public string Password { get; set; }
        public ICollection<Course> Courses { get; set; }
        public byte[] Salt { get; set; }

        public string Role {get {return "Professor";}}
    }
}