using System;
using Newtonsoft.Json;

namespace YahooWeatherParser
{
	[JsonObject()]
	public class Location
	{
		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }

		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }

		[JsonProperty(PropertyName = "region")]
		public string Region { get; set; }
	}
}

