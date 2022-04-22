using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result:IResult
    {
        public Result(bool isSuccess,string message)
        {
            Message=message;
            IsSuccess=isSuccess;
        }
        public Result(bool isSuccess)
        {
            IsSuccess=isSuccess;
        }

        public bool IsSuccess { get; }
        public string Message { get; }
    }
}
