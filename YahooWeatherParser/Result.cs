using System;
using Newtonsoft.Json;

namespace YahooWeatherParser
{
	[JsonObject()]
	public class Results
	{
		[JsonProperty(PropertyName = "channel")]
		public Channel Channel { get; set; }
	}
}

