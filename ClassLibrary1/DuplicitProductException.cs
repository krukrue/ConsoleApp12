using System.Runtime.Serialization;

namespace ClassLibrary1
{
    [Serializable]
    internal class DuplicitProductException : Exception
    {
        public DuplicitProductException()
        {
        }
        public DuplicitProductException(string? message) : base(message)
        {
        }

        public DuplicitProductException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DuplicitProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}