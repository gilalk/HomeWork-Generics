using System;
using System.Runtime.Serialization;

namespace HW_Generics
{
    [Serializable]
    internal class readOnlyArrException : Exception
    {
        public readOnlyArrException()
        {
        }

        public readOnlyArrException(string message) : base(message)
        {
        }

        public readOnlyArrException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected readOnlyArrException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}