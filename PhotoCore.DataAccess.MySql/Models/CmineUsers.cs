using System;
using System.Collections.Generic;

namespace net_core_hello.sakila
{
    public partial class CmineUsers
    {
        public int UserId { get; set; }
        public int UserGroup { get; set; }
        public string UserActive { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserLastvisit { get; set; }
        public DateTime UserRegdate { get; set; }
        public string UserGroupList { get; set; }
        public string UserEmail { get; set; }
        public string UserProfile3 { get; set; }
        public string UserProfile1 { get; set; }
        public string UserProfile2 { get; set; }
        public string UserProfile4 { get; set; }
        public string UserActkey { get; set; }
        public string UserProfile5 { get; set; }
        public string UserProfile6 { get; set; }
        public string UserLanguage { get; set; }
        public string UserEmailValid { get; set; }

        public virtual ICollection<CmineAlbums> CmineAlbums{ get; set;}
    }
}
