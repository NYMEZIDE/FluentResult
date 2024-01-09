using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentResult
{
    public abstract class AbstractResult : IResult
    {
        public bool IsFailed => Error != null;

        public bool IsSuccess => !IsFailed;

        public IError? Error { get; protected set; }

        public ISuccess? Success { get; protected set; }

        public AbstractResult WithMessage(string successMessage)
        {
            Success = new Success(successMessage);
            return this;
        }

        public AbstractResult WithError(IError error)
        {
            Error = error;
            return this;
        }

        public AbstractResult WithError(string errorMessage)
        {
            Error = new Error(errorMessage);
            return this;
        }

        public AbstractResult WithError(Exception exception)
        {
            Error = new ErrorWithException(exception);
            return this;
        }

        public AbstractResult WithError(string errorMessage, Exception exception)
        {
            Error = new ErrorWithException(errorMessage, exception);
            return this;
        }
    }

    public abstract class AbstractResult<TValue> : AbstractResult, IResult<TValue>
    {
        public TValue Value { get; protected set; }
    }
}
