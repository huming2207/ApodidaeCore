using System;
using Newtonsoft.Json;
namespace YahooWeatherParser
{
	[JsonObject()]
	public class Channel
	{
		[JsonProperty(PropertyName = "units")]
		public Units Units { get; set; }

		[JsonProperty(PropertyName = "title")]
		public string Title { get; set; }

		[JsonProperty(PropertyName = "link")]
		public string Link { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

		[JsonProperty(PropertyName = "language")]
		public string Language { get; set; }

		[JsonProperty(PropertyName = "lastBuildDate")]
		public string LastBuildDate { get; set; }

		[JsonProperty(PropertyName = "ttl")]
		public int Ttl { get; set; }

		[JsonProperty(PropertyName = "location")]
		public Location Location { get; set; }

		[JsonProperty(PropertyName = "wind")]
		public Wind Wind { get; set; }

		[JsonProperty(PropertyName = "atmosphere")]
		public Atmosphere Atmosphere { get; set; }

		[JsonProperty(PropertyName = "astronomy")]
		public Astronomy Astronomy { get; set; }

		[JsonProperty(PropertyName = "item")]
		public Item Item { get; set; }
	}
}

