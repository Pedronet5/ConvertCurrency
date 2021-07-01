using ConvertCoin.API.Configuration;
using ConvertCoin.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;

namespace ConvertCoin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertCoinController : Controller
    {
        private readonly IConvertCoinService _convertCoinService;
        private readonly ConvertCoinConfig _convertCoinConfig;
        public ConvertCoinController(IConvertCoinService convertCoinService, IOptions<ConvertCoinConfig> options)
        {
            this._convertCoinService = convertCoinService;
            _convertCoinConfig = options.Value;
        }

        [HttpGet]
        public ActionResult<dynamic> Get([FromQuery] string source, [FromQuery] string coinFor)
        {
            try
            {
                ConvertCoinConfig configuration = new ConvertCoinConfig();
                var response = _convertCoinService.GetCoinValueFromApi(source.ToUpper(), coinFor.ToUpper(), _convertCoinConfig.UriBase, _convertCoinConfig.AcessKey);

                if (!response.Success)
                    return BadRequest(response.Error.Info);

                return response.Quotes;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
