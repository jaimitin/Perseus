using System.Runtime.CompilerServices;

namespace Perseus.Core
{
    /// <summary>
    /// Provides asynchronous lazy initialization
    /// </summary>
    public class AsyncLazy<T> : Lazy<Task<T>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncLazy{T}"/> class.
        /// </summary>
        public AsyncLazy(Func<T> valueFactory) : base(() => Task.Run(valueFactory))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncLazy{T}"/> class.
        /// </summary>
        public AsyncLazy(Func<Task<T>> taskFactory) : base(() => Task.Run(() => taskFactory()))
        {
        }

        /// <summary>
        /// Gets an awaiter used to await the inner lazy value.
        /// </summary>
        /// <returns>
        /// An awaiter instance.
        /// </returns>
        public TaskAwaiter<T> GetAwaiter()
        {
            return Value.GetAwaiter();
        }
    }
}
