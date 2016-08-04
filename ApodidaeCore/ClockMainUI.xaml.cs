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
        public ClockMainUI()
        {
            this.InitializeComponent();
            timeUpdateTimer = new Timer(clockUIUpdate, null, 0, 1000);
        }

        private async void clockUIUpdate(object state)
        {
            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;


            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.High, () => {

                hourTextBlock.Text = currentHour.ToString();
                minuteTextBlock.Text = currentMinute.ToString();
            });

            Debug.WriteLine("Called +1s !");
        }
    }
}
