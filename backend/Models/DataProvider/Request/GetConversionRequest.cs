using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.DataProvider.Request
{
    public class GetConversionRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public int Amount { get; set; }
    }
}
