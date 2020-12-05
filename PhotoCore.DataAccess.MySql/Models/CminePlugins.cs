using System;
using System.Collections.Generic;

namespace PhotoCore.DataAccess.MySql.Models
{
    public partial class CminePlugins
    {
        public int PluginId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int Priority { get; set; }
    }
}
