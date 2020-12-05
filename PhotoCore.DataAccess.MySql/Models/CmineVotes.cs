using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineVotes
    {
        public int PicId { get; set; }
        public string UserMd5Id { get; set; }
        public int VoteTime { get; set; }
    }
}
