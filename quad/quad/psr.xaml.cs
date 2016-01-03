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
    public sealed partial class psr : Page
    {
        public psr()
        {
            this.InitializeComponent();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
        int Wins = 0;
        int Losses = 0;
        int Ties = 0;

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            W1.Text = "";
            t1.Text = "";
            l1.Text = "";

            PictureBox3.Visibility = Visibility.Visible;
            PictureBox1.Visibility = Visibility.Collapsed;
            PictureBox2.Visibility = Visibility.Collapsed;
            var ran1 = new Random();
            var temp1 = ran1.Next(1, 4);


            for (int i = 1; i <= 3; i++)
            {
                if (temp1 == 1)
                {
                    PictureBox4.Visibility = Visibility.Visible;
                    PictureBox5.Visibility = Visibility.Collapsed;
                    PictureBox6.Visibility = Visibility.Collapsed;

                }
                if (temp1 == 2)
                {
                    PictureBox5.Visibility = Visibility.Visible;
                    PictureBox4.Visibility = Visibility.Collapsed;
                    PictureBox6.Visibility = Visibility.Collapsed;

                }
                if (temp1 == 3)
                {
                    PictureBox6.Visibility = Visibility.Visible;
                    PictureBox5.Visibility = Visibility.Collapsed;
                    PictureBox4.Visibility = Visibility.Collapsed;


                }

                if (temp1 == 1)
                {
                    W1.Text = "You Win";
                    Wins = Wins + 1;
                    aaa.Play();




                }
                if (temp1 == 2)
                {
                    l1.Text = "You Lose";
                    Losses = Losses + 1;
                    bbb.Play();


                }

                if (temp1 == 3)
                {

                    t1.Text = "It's Tie";
                    Ties = Ties + 1;
                    aaa_Copy.Play();

                }
            };
        }

        private void b5_Copy_Click(object sender, RoutedEventArgs e)
        {
            W1.Text = "";
            t1.Text = "";
            l1.Text = "";
            PictureBox2.Visibility = Visibility.Collapsed;
            PictureBox3.Visibility = Visibility.Collapsed;
            PictureBox5.Visibility = Visibility.Collapsed;
            PictureBox6.Visibility = Visibility.Collapsed;
            PictureBox1.Visibility = Visibility.Visible;
            PictureBox4.Visibility = Visibility.Visible;

        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            W1.Text = "";
            t1.Text = "";
            l1.Text = "";

            PictureBox2.Visibility = Visibility.Visible;
            PictureBox1.Visibility = Visibility.Collapsed;
            PictureBox3.Visibility = Visibility.Collapsed;
            var ran1 = new Random();
            var temp1 = ran1.Next(1, 4);
            for (int i = 1; i <= 3; i++)
            {
                if (temp1 == 1)
                {
                    PictureBox4.Visibility = Visibility.Visible;
                    PictureBox5.Visibility = Visibility.Collapsed;
                    PictureBox6.Visibility = Visibility.Collapsed;

                }
                if (temp1 == 2)
                {
                    PictureBox5.Visibility = Visibility.Visible;
                    PictureBox4.Visibility = Visibility.Collapsed;
                    PictureBox6.Visibility = Visibility.Collapsed;

                }
                if (temp1 == 3)
                {
                    PictureBox6.Visibility = Visibility.Visible;
                    PictureBox5.Visibility = Visibility.Collapsed;
                    PictureBox4.Visibility = Visibility.Collapsed;

                }

            }



            if (temp1 == 1)
            {


                l1.Text = "You Lose";
                Losses = Losses + 1;
                bbb.Play();


            }
            if (temp1 == 2)
            {

                t1.Text = "It's Tie";
                Ties = Ties + 1;
                aaa_Copy.Play();

            }

            if (temp1 == 3)
            {
                W1.Text = "You Win";
                Wins = Wins + 1;
                aaa.Play();
            }
        }


        private void b6_Click(object sender, RoutedEventArgs e)
        {
            W1.Text = "";
            t1.Text = "";
            l1.Text = "";
            PictureBox1.Visibility = Visibility.Visible;
            PictureBox2.Visibility = Visibility.Collapsed;
            PictureBox3.Visibility = Visibility.Collapsed;
            var ran1 = new Random();
            var temp1 = ran1.Next(1, 4);
            for (int i = 1; i <= 3; i++)
            {
                if (temp1 == 1)
                {
                    PictureBox4.Visibility = Visibility.Visible;
                    PictureBox5.Visibility = Visibility.Collapsed;
                    PictureBox6.Visibility = Visibility.Collapsed;

                }
                if (temp1 == 2)
                {
                    PictureBox5.Visibility = Visibility.Visible;
                    PictureBox4.Visibility = Visibility.Collapsed;
                    PictureBox6.Visibility = Visibility.Collapsed;

                }
                if (temp1 == 3)
                {
                    PictureBox6.Visibility = Visibility.Visible;
                    PictureBox5.Visibility = Visibility.Collapsed;
                    PictureBox4.Visibility = Visibility.Collapsed;


                }
                if (temp1 == 1)
                {
                    t1.Text = "It's Tie";
                    Ties = Ties + 1;
                    aaa_Copy.Play();


                }
                if (temp1 == 2)
                {
                    W1.Text = "You Win";
                    Wins = Wins + 1;
                    aaa.Play();



                }

                if (temp1 == 3)
                {
                    l1.Text = "You Lose";
                    Losses = Losses + 1;
                    bbb.Play();

                }
            }

        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(listpage));
        }

        private async void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            var messagedialog = new Windows.UI.Popups.MessageDialog("Are you sure you want to exit?");
            messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Yes", (UIcommandInvokedHandler) =>
            {
                Application.Current.Exit();
            }
                ));
            messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("No"));
            await messagedialog.ShowAsync();
        }
    }
}
