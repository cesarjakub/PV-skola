﻿using System.Runtime.Serialization;

namespace stack
{
    [Serializable]
    internal class StackEmptyException : Exception
    {
        public StackEmptyException()
        {
        }

        public StackEmptyException(string? message) : base(message)
        {
        }

        public StackEmptyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StackEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}