using System.Collections.Generic;
using PhotoCore.DataAccess.MySql.Models;


namespace PhotoCore.Mvc.Models.Home
{
    public class IndexModel
    {
        public IEnumerable<CmineUsers> Users { get; set; }
    }

    public class AlbumItem{
        public int Aid { get; set; }
        public string Title { get; set; }
        public int Category { get; set; }
        public string FileName { get; set; }

        public string ThumbnailUrl {
            get{
                return $"http://photo.killfly.com/albums/userpics/{Category}/thumb_{FileName}";
            }
        }
    }
}