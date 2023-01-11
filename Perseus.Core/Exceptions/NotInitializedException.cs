namespace Perseus.Core.Exceptions
{
    /// <summary>
    /// Represents an error that occurs when an object is interacted with before being initialized
    /// </summary>
    public class NotInitializedException : Exception
    {
        public NotInitializedException()
        {
        }

        public NotInitializedException(string? message) : base(message)
        {
        }

        public NotInitializedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
