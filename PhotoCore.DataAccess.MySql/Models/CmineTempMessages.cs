using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineTempMessages
    {
        public string MessageId { get; set; }
        public int? UserId { get; set; }
        public int? Time { get; set; }
        public string Message { get; set; }
    }
}
