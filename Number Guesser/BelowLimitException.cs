using System;
using System.Runtime.Serialization;

namespace Number_Guesser
{
    [Serializable]
    internal class BelowLimitException : Exception
    {

        public BelowLimitException()
        {
        }

        public BelowLimitException(int max) : base(String.Format("Number is less than {0}", max))
        {


        }

        public BelowLimitException(string message) : base(message)
        {
            Console.WriteLine("Number is less than " + max);
        }

        public BelowLimitException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BelowLimitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}