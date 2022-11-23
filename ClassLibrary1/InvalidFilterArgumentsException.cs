using System.Runtime.Serialization;

namespace ClassLibrary1
{
    [Serializable]
    internal class InvalidFilterArgumentsException : Exception
    {
        public InvalidFilterArgumentsException()
        {
            Console.WriteLine("Incorrect filter arguments");
        }

        public InvalidFilterArgumentsException(string? message) : base(message)
        {
        }

        public InvalidFilterArgumentsException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        protected InvalidFilterArgumentsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}