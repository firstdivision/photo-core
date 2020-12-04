using System;
using System.Collections.Generic;

namespace net_core_hello.sakila
{
    public partial class CmineComments
    {
        public int Pid { get; set; }
        public int MsgId { get; set; }
        public string MsgAuthor { get; set; }
        public string MsgBody { get; set; }
        public DateTime MsgDate { get; set; }
        public string MsgRawIp { get; set; }
        public string MsgHdrIp { get; set; }
        public string AuthorMd5Id { get; set; }
        public int AuthorId { get; set; }
        public string Approval { get; set; }
        public string Spam { get; set; }
    }
}
