using System;

namespace Amozeshyar.Database
{
    public abstract class DBObject
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DBObject()
        {
            CreateTime=DateTime.Now;
        }
    }
}