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

        public TaskAwaiter<T> GetAwaiter() => Value.GetAwaiter();
    }
}
