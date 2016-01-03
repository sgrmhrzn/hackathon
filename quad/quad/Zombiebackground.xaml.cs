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
    public sealed partial class Zombiebackground : Page
    {
        public Zombiebackground()
        {
            this.InitializeComponent();
        }
        DispatcherTimer timer;
        int maxTime = 10;
        public static int sa;

        void timer_Tick(object sender, object e)
        {
            maxTime--;
            timeleft.Text = maxTime.ToString();

            if (maxTime == 0)
            {
                timer.Stop();
                //stopStoryboard1();
                this.Frame.Navigate(typeof(Zombiescorepage));

            }

            if (maxTime == 9)
            {
                Storyboard2.Begin();
            }
            if (maxTime == 8)
            {
                Storyboard3.Begin();
            }
            if (maxTime == 7)
            {
                Storyboard4.Begin();

            }
            if (maxTime == 6)
            {
                Storyboard5.Begin();

            }
            if (maxTime == 5)
            {
                Storyboard6.Begin();

            }
            if (maxTime == 4)
            {
                Storyboard7.Begin();

            }
            if (maxTime == 3)
            {
                Storyboard8.Begin();

            }
            if (maxTime == 2)
            {
                Storyboard9.Begin();

            }
            if (maxTime == 1)
            {
                Storyboard10.Begin();

            }
        }
        

        private void zombie_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sa = sa + 1;
            score_box.Text = (sa).ToString();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Zombiebackground));
        }

        private void zombiebackground_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard1.Begin();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

           
        }
    }
}
