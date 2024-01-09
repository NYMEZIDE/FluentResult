using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentResult
{
    public partial class Result : AbstractResult
    {
        private Result() { }

        public static Result Ok()
        {
            return new Result();
        }

        public static Result<TValue> Ok<TValue>(TValue value)
        {
            var result = new Result<TValue>();
            result.WithValue(value);
            return result;
        }

        public static Result<TValue> Ok<TValue>(TValue value, string successMessage)
        {
            var result = new Result<TValue>();
            result.WithValue(value);
            result.WithMessage(successMessage);
            return result;
        }

        public static Result Ok(string successMessage)
        {
            var result = new Result();
            result.WithMessage(successMessage);
            return result;
        }

        public static Result Fail(IError error)
        {
            var result = new Result();
            result.WithError(error);
            return result;
        }

        public static Result Fail(string errorMessage)
        {
            var result = new Result();
            result.WithError(errorMessage);
            return result;
        }

        public static Result Fail(Exception exception)
        {
            var result = new Result();
            result.WithError(exception);
            return result;
        }

        public static Result Fail(string errorMessage, Exception exception)
        {
            var result = new Result();
            result.WithError(errorMessage, exception);
            return result;
        }

        public static Result<TValue> Fail<TValue>(IError error)
        {
            var result = new Result<TValue>();
            result.WithError(error);
            return result;
        }

        public static Result<TValue> Fail<TValue>(string errorMessage)
        {
            var result = new Result<TValue>();
            result.WithError(errorMessage);
            return result;
        }

        public static Result<TValue> Fail<TValue>(Exception exception)
        {
            var result = new Result<TValue>();
            result.WithError(exception);
            return result;
        }

        public static Result<TValue> Fail<TValue>(string errorMessage, Exception exception)
        {
            var result = new Result<TValue>();
            result.WithError(errorMessage, exception);
            return result;
        }

        public static implicit operator bool(Result result)
            => result.IsSuccess;

        public Result ToResult()
        {
            return new Result();
        }

        public Result<TValue> ToResult<TValue>()
        {
            return new Result<TValue>();
        }
    }


    public class Result<TValue> : AbstractResult<TValue>
    {
        public Result<TValue> WithValue(TValue value)
        {
            Value = value;
            return this;
        }

        public static implicit operator bool(Result<TValue> result)
            => result.IsSuccess;

        public static implicit operator Result<TValue>(Result result)
        {
            return result.ToResult<TValue>();
        }

        public static implicit operator Result<TValue>(TValue value)
        {
            if (value is Result<TValue> r)
                return r;

            return Result.Ok(value);
        }

        public Result<TNewValue> ToResult<TNewValue>(TNewValue newValue = default)
        {
            return new Result<TNewValue>()
                .WithValue(IsFailed ? default : newValue);
        }
    }
}
