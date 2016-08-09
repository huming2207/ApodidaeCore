using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace YahooWeatherParser
{
	[JsonObject()]
	public class Item
	{
		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		[JsonProperty(PropertyName = "lat")]
		public double Latitude { get; set; }

		[JsonProperty(PropertyName = "lon")]
		public double Longitude { get; set; }

		[JsonProperty(PropertyName = "link")]
		public string Link { get; set; }

		[JsonProperty(PropertyName = "pubDate")]
		public string PublishDate { get; set; }

		[JsonProperty(PropertyName = "condition")]
		public Condition Condition { get; set; }

		[JsonProperty(PropertyName = "forecast")]
		public Forecast[] Forecast { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "guid")]
		public Guid Guid { get; set; }
	}
}

