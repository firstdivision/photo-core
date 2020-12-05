using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineSessions
    {
        public string SessionId { get; set; }
        public int? UserId { get; set; }
        public int? Time { get; set; }
        public int? Remember { get; set; }
    }
}
