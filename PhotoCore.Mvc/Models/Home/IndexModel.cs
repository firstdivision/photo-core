using System.Collections.Generic;
using net_core_hello.sakila;


namespace PhotoCore.Mvc.Models.Home
{
    public class IndexModel
    {
        public IEnumerable<UserList> Users { get; set; }
    }

    public class UserList
    {
        public CmineUsers User { get; set; }
        public IEnumerable<CmineAlbums> Albums { get; set; }
    }
}