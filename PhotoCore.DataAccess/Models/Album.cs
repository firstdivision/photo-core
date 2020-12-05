using System.Collections.Generic;
using System.Collections;

namespace PhotoCore.DataAccess.Models
{
    public class Album
    {
        public int Id { get; set; }
        public int Name { get; set; }
        
        public virtual ICollection<Photo> Photos{ get; set;}
    }
}
