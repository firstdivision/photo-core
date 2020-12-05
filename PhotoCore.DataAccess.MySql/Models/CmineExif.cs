using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineExif
    {
        [ForeignKey("CminePictures")]
        public int Pid { get; set; }

        public virtual CminePictures CminePictures{ get; set; }
        public string ExifData { get; set; }
    }
}
