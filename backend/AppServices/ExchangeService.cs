using backend.AppAdapter;
using backend.AppAdapter.interfaces;
using backend.AppServices.interfaces;
using backend.Models.DataProvider.Request;
using backend.Models.DataProvider.Response;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.AppServices
{
    public class ExchangeService : IExchangeService
    {
        private readonly IExchangeAdapter _exchangeAdapter;
        public ExchangeService(IExchangeAdapter exchangeAdapter) 
        {
            _exchangeAdapter = exchangeAdapter;
        }

        public async Task<GetConversionResponses> GetConversion(GetConversionRequest request)
        {
            try
            {
                return await _exchangeAdapter.GetConversion(request);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<GetExchangeValuesResponses> GetExchangeValues()
        {
            try
            {
                return await _exchangeAdapter.GetExchangeValues();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<GetSymbolsResponses> GetSymbols()
        {
            try
            {
                return await _exchangeAdapter.GetSymbols();
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
