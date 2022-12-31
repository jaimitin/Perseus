namespace Perseus.Core.Extensions
{
    /// <summary>
    /// Collection extensions
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Returns a specified number of contiguous elements from the end of a sequence
        /// </summary>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> that contains the specified number of elements from the end of the input squence
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="list"/> is null</exception>
        /// <exception cref="IndexOutOfRangeException"><paramref name="count"/> is greater than the total amount of list elements</exception>
        public static IEnumerable<T> TakeLast<T>(this IList<T> list, int count)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (count > list.Count)
            {
                throw new IndexOutOfRangeException(nameof(count));
            }

            for (int i = list.Count - count; i < list.Count; i++)
            {
                yield return list[i];
            }
        }
    }
}
