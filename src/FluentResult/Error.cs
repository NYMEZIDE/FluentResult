using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentResult
{
    public class Error : IError
    {
        public string Code { get; private set; }

        public string Message { get; private set; }

        protected Error()
        { }

        public Error(string error) : this()
        {
            Message = error;
        }
    }
}
