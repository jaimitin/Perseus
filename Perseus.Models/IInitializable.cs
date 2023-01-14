namespace Perseus.Models
{
    /// <summary>
    /// Represents an initializable item
    /// </summary>
    public interface IInitializable
    {
        /// <summary>
        /// Initialize the instance
        /// </summary>
        void Initialize();

        /// <summary>
        /// Whether the instance has been initialized or not
        /// </summary>
        bool IsInitialized { get; }
    }
}
