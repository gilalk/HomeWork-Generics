using System;
using System.Runtime.Serialization;

namespace HW_Generics
{
    [Serializable]
    internal class OutOfSpaceException : Exception
    {
        public OutOfSpaceException()
        {
        }

        public OutOfSpaceException(string message) : base(message)
        {
        }

        public OutOfSpaceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfSpaceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}