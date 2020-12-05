
using System.Collections.Generic;
using PhotoCore.DataAccess.MySql.Models;

namespace PhotoCore.Mvc.Models.UserAlbums
{
    public class IndexModel
    {
        public IEnumerable<CmineAlbums> Albums { get; set; }
    }
}