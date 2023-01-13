namespace Perseus.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occur when an object is interacted with before being initialized
    /// </summary>
    public class NotInitializedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotInitializedException"/> class
        /// </summary>
        public NotInitializedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotInitializedException"/> class with a specified error message.
        /// </summary>
        /// <param name="message"></param>
        public NotInitializedException(string? message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotInitializedException"/> class with a specified error message
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public NotInitializedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
