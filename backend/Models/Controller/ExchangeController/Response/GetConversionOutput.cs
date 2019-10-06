using backend.Models.DataProvider.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Controller.ExchangeController.Response
{
    public class GetConversionOutput
    {
        public DateTime date { get; set; }
        public GetConversionResponses data { get; set; }
    }
}
