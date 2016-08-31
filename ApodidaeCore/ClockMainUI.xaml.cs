using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using YahooWeatherParser;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ApodidaeCore
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ClockMainUI : Page
    {
        private Timer timeUpdateTimer;
        private Timer weatherUpdateTimer;
        private static class Settings
        {
            public static string City = "Melbourne";
            public static string Region = "Victoria";
            public static bool UseCelsius = true;
        }
        public ClockMainUI()
        {
            this.InitializeComponent();

            // Main time information updating timer, runs 1 second per upgrade
            timeUpdateTimer = new Timer(timeUpdate, null, 0, 1000);

            // Weather information updating timer, runs 300s per upgrade
            weatherUpdateTimer = new Timer(weatherInfoUpdate, null, 0, 300000);
        }

        /// <summary>
        /// This method is used for upgrading the time info in the UI.
        /// </summary>
        /// <param name="state"></param>
        private async void timeUpdate(object state)
        {
            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;

            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Low, () => {
                hourTextBlock.Text = currentHour.ToString();
                if (currentMinute < 10)
                {
                    minuteTextBlock.Text = "0" + currentMinute.ToString();
                }
                else
                {
                    minuteTextBlock.Text = currentMinute.ToString();
                }
            });
        }

        /// <summary>
        /// This method is used for upgrading the weather information
        /// </summary>
        /// <param name="state"></param>
        private async void weatherInfoUpdate(object state)
        {
            var yahooWeather = new YahooWeatherControl(Settings.UseCelsius);
            var weatherResult = await yahooWeather.DoQuery(Settings.Region, Settings.City);
            string temperatureInfo = weatherResult.Results.Channel.Item.Condition.Temperature;
            string weatherConditionInfo = weatherResult.Results.Channel.Item.Condition.StatusText;
            uint weatherStatusCode = (uint)weatherResult.Results.Channel.Item.Condition.Code;
           



            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () => {
                weatherInfoTextBlock.Text = weatherConditionInfo + " - " + temperatureInfo + "℃";
                switch (weatherStatusCode)
                {
                    // Rainy
                    case 11:
                    case 12:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/rain.png"));
                            break;
                        }

                    // Snowy
                    case 15:
                    case 16:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/snowflake.png"));
                            break;
                        }

                    // Thunderstorm
                    case 4:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/thunderstorm.png"));
                            break;
                        }

                    // Sunny (at day, of course!)
                    case 32:
                    case 34:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/sun.png"));
                            break;
                        }

                    // Clear at night
                    case 31:
                    case 33:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/moon.png"));
                            break;
                        }

                    // Cloudy at day
                    case 28:
                    case 30:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/cloudyday.png"));
                            break;
                        }

                    // Cloudy at night
                    case 27:
                    case 29:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/cloudynight.png"));
                            break;
                        }

                    // Cloudy
                    case 26:
                        {
                            weatherInfoIconImage.Source = new BitmapImage(new Uri(BaseUri, "/Assets/Images/cloudy.png"));
                            break;
                        }

                    //
                   
                }
            }); 
        }
    }
}
