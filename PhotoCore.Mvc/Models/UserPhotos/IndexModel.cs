
using System.Collections.Generic;
using PhotoCore.DataAccess.MySql.Models;

namespace PhotoCore.Mvc.Models.UserPhotos
{
    public class IndexModel
    {
        public IEnumerable<CminePictures> Pictures { get; set; }
    }
}