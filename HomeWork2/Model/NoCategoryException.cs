using System;
using System.Runtime.Serialization;

namespace Model
{
    [Serializable]
    public class NoCategoryException : Exception
    {
        public NoCategoryException()
        {
        }

        public NoCategoryException(string message) : base(message)
        {
        }

        public NoCategoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoCategoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}