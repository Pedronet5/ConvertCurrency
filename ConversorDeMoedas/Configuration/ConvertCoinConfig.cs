using Microsoft.Extensions.Options;
using System.Configuration;

namespace ConvertCoin.API.Configuration
{
    public class ConvertCoinConfig 
    {
        public string AcessKey { get; set; }
        public string UriBase { get; set; }
    }
}
