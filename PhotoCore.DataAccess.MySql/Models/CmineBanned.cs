﻿using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CmineBanned
    {
        public int BanId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string IpAddr { get; set; }
        public DateTime? Expiry { get; set; }
        public byte BruteForce { get; set; }
    }
}
