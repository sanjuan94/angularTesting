using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.DataProvider.Response
{
    public class GetConversionResponses : BaseResponse
    {
        public Query query { get; set; }
        public Info info { get; set; }
        public string historical { get; set; }
        public string date { get; set; }
        public double result { get; set; }
    }

    public class Query
    {
        public string from { get; set; }
        public string to { get; set; }
        public int amount { get; set; }
    }

    public class Info
    {
        public int timestamp { get; set; }
        public double rate { get; set; }
    }
}
