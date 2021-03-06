﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CminePictures
    {
        public int Pid { get; set; }

        
        [ForeignKey("CmineAlbums")]
        public int Aid { get; set; }
        public virtual CmineAlbums CmineAlbums { get; set;}

        public string Filepath { get; set; }
        public string Filename { get; set; }
        public int Filesize { get; set; }
        public int TotalFilesize { get; set; }
        public short Pwidth { get; set; }
        public short Pheight { get; set; }
        public int Hits { get; set; }
        public DateTime Mtime { get; set; }
        public int Ctime { get; set; }
        public int OwnerId { get; set; }
        public int PicRating { get; set; }
        public int Votes { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Keywords { get; set; }
        public string Approved { get; set; }
        public int Galleryicon { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public byte UrlPrefix { get; set; }
        public string PicRawIp { get; set; }
        public string PicHdrIp { get; set; }
        public string LasthitIp { get; set; }
        public int Position { get; set; }
        public string GuestToken { get; set; }

        public virtual CmineExif CmineExif {get; set;}
    }
}
