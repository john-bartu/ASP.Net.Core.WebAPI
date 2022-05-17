using System;

namespace Models.DbEntities
{
    public class LoginLog : BaseEntity
    {
        public string UserEmail { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
