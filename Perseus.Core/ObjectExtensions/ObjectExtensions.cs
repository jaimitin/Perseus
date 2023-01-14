namespace Perseus.Core.Extensions
{
    /// <summary>
    /// Object extensions
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Assert that this object is not null
        /// </summary>
        public static void NotNull(this object? obj, string? name = null)
        {
            ArgumentNullException.ThrowIfNull(obj, name);
        }
    }
}
