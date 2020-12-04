public class Photo
{
    public int Id { get; set; }
    public string Name { get; set; }


    public virtual Album Album { get; set; }
}