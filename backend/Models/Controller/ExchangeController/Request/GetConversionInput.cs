using backend.Models.DataProvider.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Controller.ExchangeController.Request
{
    public class GetConversionInput
    {
        public string userName { get; set; }
        public DateTime date { get; set; }
        public GetConversionRequest data { get; set; }
    }
}
