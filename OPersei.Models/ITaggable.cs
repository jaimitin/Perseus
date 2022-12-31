namespace OPersei.Models
{
    public interface ITaggable
    {
        IEnumerable<string> Tags { get; }
    }
}
