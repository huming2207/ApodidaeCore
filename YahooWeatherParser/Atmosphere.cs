using System;
using Newtonsoft.Json;

namespace YahooWeatherParser
{
	[JsonObject()]
	public class Atmosphere
	{
		[JsonProperty(PropertyName = "humidity")]
		public int Humidity { get; set; }

		[JsonProperty(PropertyName = "pressure")]
		public double Pressure { get; set; }

		[JsonProperty(PropertyName = "rising")]
		public int Rising { get; set; }

		[JsonProperty(PropertyName = "visibility")]
		public double Visibility { get; set; }
	}
}

