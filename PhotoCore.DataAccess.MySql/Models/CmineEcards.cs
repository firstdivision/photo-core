using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineEcards
    {
        public int Eid { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string RecipientName { get; set; }
        public string RecipientEmail { get; set; }
        public string Link { get; set; }
        public string Date { get; set; }
        public string SenderIp { get; set; }
    }
}
