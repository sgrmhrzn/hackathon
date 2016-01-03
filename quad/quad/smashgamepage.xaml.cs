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
    public sealed partial class smashgamepage : Page
    {
        public smashgamepage()
        {
            this.InitializeComponent();
        }

        public static int x = 0;

        //global declaration
        DispatcherTimer timer;
        int maxTime = 5;

        void timer_Tick(object sender, object e)
        {
            maxTime--;
            timeLeftTicker.Text = maxTime.ToString();
            if (maxTime == 0)
            {
                timer.Stop();
                this.Frame.Navigate(typeof(smashscorepage));


            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }


        private void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {




        }

        private void TextBlock_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void TextBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (maxTime != 0)
            {
                if (x % 2 == 0)
                {
                    p2.Visibility = Visibility.Visible;
                    p1.Visibility = Visibility.Collapsed;
                    x = x + 1;
                }
                else
                {
                    p1.Visibility = Visibility.Visible;
                    p2.Visibility = Visibility.Collapsed;
                    x = x + 1;
                }

                txtscore.Text = (x).ToString();
            } txtscore.Text = (x).ToString();
            

        }
    }
}
