using System.Collections.Generic;

namespace Amozeshyar.Database
{
    public class Field : DBObject       
    {
        public string Title { get; set; }
        public int TheoryHours { get; set; }
        public int PracticalHours { get; set; }
        public ICollection<PreRegisteration> PreRegisterations { get; set; }
        public ICollection<Course> Courses { get; set;}
    }
}