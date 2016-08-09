using System;
namespace YahooWeatherParser
{
	public class YahooWeatherNullContentException : Exception
	{
		public YahooWeatherNullContentException()
		{
			// Leave it empty
		}

		public YahooWeatherNullContentException(string message, Exception inner) : base(message, inner)
		{
			// Leave it empty
		}

		public YahooWeatherNullContentException(string message) : base(message)
		{
			// Leave it empty
		}

		public string Json { get; set; }
	}
}

