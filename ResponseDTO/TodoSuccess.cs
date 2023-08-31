using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.ResponseDTO
{
    public class TodoSuccess
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public TodoSuccess(int code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
    }
}