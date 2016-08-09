using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YahooWeatherParser
{
	[JsonObject()]
	public class Units
	{
		[JsonProperty(PropertyName = "distance")]
		public string Distance { get; set; }

		[JsonProperty(PropertyName = "pressure")]
		public string Pressure { get; set; }

		[JsonProperty(PropertyName = "speed")]
		public string Speed { get; set; }

		[JsonProperty(PropertyName = "temperature")]
		public string Temperature { get; set; }
	}
}

