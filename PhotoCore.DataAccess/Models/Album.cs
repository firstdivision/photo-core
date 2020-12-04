using System.Collections.Generic;
using System.Collections;

public class Album
{
    public int Id { get; set; }
    public int Name { get; set; }
    
    public virtual ICollection<Photo> Photos{ get; set;}
}