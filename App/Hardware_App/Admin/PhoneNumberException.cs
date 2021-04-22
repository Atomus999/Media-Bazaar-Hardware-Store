using System;
using System.Runtime.Serialization;

namespace Hardware_App
{
    [Serializable]
    internal class PhoneNumberException : Exception
    {
        public PhoneNumberException()
        {
        }

        public PhoneNumberException(string message) : base(message)
        {
        }

        public PhoneNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PhoneNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}