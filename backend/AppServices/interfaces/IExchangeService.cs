using backend.Models.DataProvider.Request;
using backend.Models.DataProvider.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.AppServices.interfaces
{
    public interface IExchangeService
    {
        Task<GetConversionResponses> GetConversion(GetConversionRequest request);
        Task<GetExchangeValuesResponses> GetExchangeValues();
        Task<GetSymbolsResponses> GetSymbols();

    }
}
