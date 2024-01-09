using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentResult
{
    public interface IResult
    {
        bool IsFailed { get; }

        bool IsSuccess { get; }

        IError? Error { get; }

        ISuccess? Success { get; }
    }

    public interface IResult<out TValue> : IResult
    {
        TValue Value { get; }
    }
}
