using System.Collections.Generic;
using net_core_hello.sakila;


namespace PhotoCore.Mvc.Models.Home
{
    public class IndexModel
    {
        public IEnumerable<UserListItem> Users { get; set; }
    }

    public class UserListItem
    {
        public string UserName { get; set; }
        public IEnumerable<AlbumItem> Albums{ get; set;}
        //public CmineUsers User { get; set; }
        //public IEnumerable<CmineAlbums> Albums { get; set; }
    }

    public class AlbumItem{
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