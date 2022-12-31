namespace Perseus.Models
{
    /// <summary>
    /// Represents a taggable item
    /// </summary>
    public interface ITaggable
    {
        /// <summary>
        /// Tags
        /// </summary>
        IEnumerable<string> Tags { get; }
    }
}
