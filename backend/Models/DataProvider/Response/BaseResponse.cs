using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.DataProvider.Response
{
    public class BaseResponse
    {
        public bool success { get; set; }
        public Error error { get; set; }
    }

    public class Error
    {
        public int code { get; set; }
        public string trype { get; set; }
        public string info { get; set; }
    }
}
