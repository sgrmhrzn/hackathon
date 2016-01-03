using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace quad
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class hand : Page
    {
        public hand()
        {
            this.InitializeComponent();
        }
        DispatcherTimer timer;
        int maxTime = 5;
        public static int sc;

        void timer_Tick(object sender, object e)
        {
            maxTime--;
            timeLeft.Text = maxTime.ToString();
            if (maxTime == 0)
            {
                timer.Stop();
                //stopStoryboard1();
                this.Frame.Navigate(typeof(scorepage));
                //messageBoxRetry();


            }
        }


        private void grid1_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void obj_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            sc = sc + 10;
            scOut.Text = (sc).ToString();

        }





    }
}
