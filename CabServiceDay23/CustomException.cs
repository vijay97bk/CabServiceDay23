using System;
using System.Collections.Generic;
using System.Text;

namespace CabServiceDay23
{
    public class InvoiceGeneratorException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, INVALID_USER_ID
        }
        public InvoiceGeneratorException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
