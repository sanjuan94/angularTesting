using backend.AppAdapter.interfaces;
using backend.Models.Application.Settings;
using backend.Models.DataProvider.Request;
using backend.Models.DataProvider.Response;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace backend.AppAdapter
{
    public class ExchangeAdapter : IExchangeAdapter
    {
        HttpClient _client;
        AppSettings _settings;
        public ExchangeAdapter(IOptions<AppSettings> settings)
        {
            _client = new HttpClient();

            _settings = settings.Value;
        }

        public async Task<GetConversionResponses> GetConversion(GetConversionRequest request)
        {
            try
            {
                var URL = $@"{_settings.dataProvider.apiRestBaseUrl}convert?access_key={_settings.dataProvider.apiKey}&from={request.From}&to={request.To}&amount={request.Amount}";
                var response = await _client.GetAsync(URL);
                return await response.Content.ReadAsAsync<GetConversionResponses>();
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
                var URL = $@"{_settings.dataProvider.apiRestBaseUrl}latest?access_key={_settings.dataProvider.apiKey}";
                var response = await _client.GetAsync(URL);
                return await response.Content.ReadAsAsync<GetExchangeValuesResponses>();
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
                var URL = $@"{_settings.dataProvider.apiRestBaseUrl}symbols?access_key={_settings.dataProvider.apiKey}";
                var response = await _client.GetAsync(URL);
                return await response.Content.ReadAsAsync<GetSymbolsResponses>();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
