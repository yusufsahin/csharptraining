
namespace ExceptionHandling
{
    [Serializable]
    internal class GecersizYasException : Exception
    {
        public GecersizYasException()
        {
        }

        public GecersizYasException(string? message) : base(message)
        {
        }

        public GecersizYasException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}