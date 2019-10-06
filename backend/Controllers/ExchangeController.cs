using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.AppServices.interfaces;
using backend.Models.Application.Settings;
using backend.Models.Controller.ExchangeController.Request;
using backend.Models.Controller.ExchangeController.Response;
using backend.Models.DataProvider.Request;
using backend.Models.DataProvider.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeController : Controller
    {
        private readonly AppSettings _settings;
        private readonly IExchangeService _exchangeService;
        public ExchangeController(IOptions<AppSettings> settings,
                                  IExchangeService exchangeService)
        {
            _settings = settings.Value;
            _exchangeService = exchangeService;
        }

        [HttpGet]
        public ActionResult<GetSymbolsResponses> Get()
        {
            try
            {
                return Ok(_exchangeService.GetSymbols().Result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("GetExchangeValues")]
        public ActionResult<GetConversionOutput> GetExchangeValues()
        {
            try
            {
                return Ok(_exchangeService.GetExchangeValues().Result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("GetSymbols")]
        public ActionResult<GetConversionOutput> GetSymbols()
        {
            try
            {
                return Ok(_exchangeService.GetSymbols().Result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost("GetConversion")]
        public ActionResult<GetConversionOutput>GetConversion(GetConversionInput request)
        {
            try
            {
                return Ok(_exchangeService.GetConversion(request.data).Result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}