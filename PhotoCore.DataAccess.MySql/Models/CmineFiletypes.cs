using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineFiletypes
    {
        public string Extension { get; set; }
        public string Mime { get; set; }
        public string Content { get; set; }
        public string Player { get; set; }
    }
}
