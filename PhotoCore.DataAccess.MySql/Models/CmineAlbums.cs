using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_core_hello.sakila
{
    public partial class CmineAlbums
    {
        public int Aid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Visibility { get; set; }
        public string Uploads { get; set; }
        public string Comments { get; set; }
        public string Votes { get; set; }
        public int Pos { get; set; }
        public int Category { get; set; }

        [ForeignKey("CmineUser")]
        public int Owner { get; set; }
        public virtual CmineUsers CmineUser { get; set; }
        public int PicCount { get; set; }
        public int Thumb { get; set; }
        public DateTime LastAddition { get; set; }
        public string StatUptodate { get; set; }
        public string Keyword { get; set; }
        public string AlbPassword { get; set; }
        public string AlbPasswordHint { get; set; }
        public int ModeratorGroup { get; set; }
        public int AlbHits { get; set; }

        public virtual ICollection<CminePictures> CminePictures { get; set;}
    }
}
