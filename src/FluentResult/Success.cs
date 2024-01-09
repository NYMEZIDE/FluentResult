using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentResult
{
    public class Success : ISuccess
    {
        public string Message { get; protected set; }

        protected Success()
        { }

        public Success(string message) : this()
        {
            Message = message;
        }
    }
}
