using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineVoteStats
    {
        public int Sid { get; set; }
        public string Pid { get; set; }
        public short Rating { get; set; }
        public string Ip { get; set; }
        public long Sdate { get; set; }
        public string Referer { get; set; }
        public string Browser { get; set; }
        public string Os { get; set; }
        public int Uid { get; set; }
    }
}
