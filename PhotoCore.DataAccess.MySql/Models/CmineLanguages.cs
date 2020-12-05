using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineLanguages
    {
        public string LangId { get; set; }
        public string EnglishName { get; set; }
        public string NativeName { get; set; }
        public string CustomName { get; set; }
        public string Flag { get; set; }
        public string Abbr { get; set; }
        public string Available { get; set; }
        public string Enabled { get; set; }
        public string Complete { get; set; }
    }
}
