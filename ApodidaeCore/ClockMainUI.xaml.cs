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

            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () => {

                hourTextBlock.Text = currentHour.ToString();
                minuteTextBlock.Text = currentMinute.ToString();
            });
        }

        private async void weatherInfoUpdate(object state)
        {
            
        }
    }
}
