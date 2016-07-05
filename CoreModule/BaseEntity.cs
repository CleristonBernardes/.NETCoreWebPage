using System;

namespace CoreModule
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string AddedUser { get; set; }
        public string ModifiedUser { get; set; }
        public string IP { get; set; }
    }
}
