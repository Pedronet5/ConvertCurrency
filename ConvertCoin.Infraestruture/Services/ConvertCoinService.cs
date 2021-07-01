using ConvertCoin.Domain.Entities;
using ConvertCoin.Domain.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCoin.Infraestruture.Services
{
    public class ConvertCoinService : IConvertCoinService
    {
        public CoinValueEntity GetCoinValueFromApi(string source, string coinFor, string UriBase, string AcessKey)
        {
            var client = new RestClient(UriBase + "live?access_key=" + AcessKey + "&source=" + source + "&currencies=" + coinFor + "&format=1");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            CoinValueEntity coinValueEntity = JsonConvert.DeserializeObject<CoinValueEntity>(response.Content.ToString());

            return coinValueEntity;
        }
    }
}
