using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineExif
    {
        public int Pid { get; set; }
        public string ExifData { get; set; }
    }
}
