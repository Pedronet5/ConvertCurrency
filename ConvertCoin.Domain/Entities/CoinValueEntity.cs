using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCoin.Domain.Entities
{
	public class CoinValueEntity
	{
		[JsonProperty]
		public bool Success { get; set; }
		[JsonProperty]
		public string Source { get; set; }
        [JsonProperty("Quotes")]
		public Dictionary<string, string> Quotes { get; set; }

		[JsonProperty]
		public Error Error { get; set; }
	}

	public class Error
	{
		[JsonProperty]
		public int Code { get; set; }
		[JsonProperty]
		public string Type { get; set; }
		[JsonProperty]
		public string Info { get; set; }
	}
}
