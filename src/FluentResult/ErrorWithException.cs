using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentResult
{
    public class ErrorWithException : Error, IErrorWithException
    {
        public Exception Exception { get; }

        public ErrorWithException(Exception exception)
            : this(exception.Message, exception)
        { }

        public ErrorWithException(string message, Exception exception)
            : base(message)
        {
            Exception = exception;
        }
    }
}
