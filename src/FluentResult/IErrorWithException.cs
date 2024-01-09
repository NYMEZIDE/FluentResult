using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentResult
{
    public interface IErrorWithException : IError
    {
        Exception Exception { get; }
    }
}
