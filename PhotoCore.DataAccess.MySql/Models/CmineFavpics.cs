using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineFavpics
    {
        public int UserId { get; set; }
        public string UserFavpics { get; set; }
    }
}
