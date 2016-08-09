using System;

namespace YahooWeatherParser
{
	public class YahooWeatherGeneralException : Exception
	{
		public YahooWeatherGeneralException()
		{
			// Leave it empty
		}

		public YahooWeatherGeneralException(string message, Exception inner) : base(message, inner)
		{
			// Leave it empty
		}

		public YahooWeatherGeneralException(string message) : base(message)
		{
			// Leave it empty
		}

		public string Json { get; set; }
	}
}

