using System;
using System.Collections.Generic;

namespace net_core_hello.sakila
{
    public partial class CmineCategories
    {
        public int Cid { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Pos { get; set; }
        public int Parent { get; set; }
        public int Thumb { get; set; }
        public int SubcatCount { get; set; }
        public int AlbCount { get; set; }
        public int PicCount { get; set; }
        public string StatUptodate { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public int Depth { get; set; }
    }
}
