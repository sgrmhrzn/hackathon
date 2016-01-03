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
    public sealed partial class mazerunner : Page
    {
        public mazerunner()
        {
            this.InitializeComponent();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
        int x = 1;
        DispatcherTimer timer;
        int maxTime = 30;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        


        private async void rectangle_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
               
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle5_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle6_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle7_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();
            }
        }

        private async void rectangle11_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle9_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle8_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();
            }
        }

        private async void rectangle10_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle14_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();
            }
        }

        private async void rectangle12_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();
            }

        }

        private async void rectangle13_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();
            }
        }

        private async void rectangle1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle15_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle18_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle16_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle1_Copy1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle17_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void rectangle1_Copy_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

        private async void Ellipse_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();

            }
        }

         async void timer_Tick(object sender, object e)
        {
            maxTime--;
            timeLeftTicker.Text = maxTime.ToString();
            if (maxTime == 0)
            {
                timer.Stop();
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You Loose.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
                // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();


               


            }
        }
        private void grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private async  void Image_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (x == 2)
            {
                timer.Stop();
                
                
                    
                var messagedialog = new Windows.UI.Popups.MessageDialog(" You won.......Are you sure you want to exit?");
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Play Again", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(mazerunner));
                }
                    ));
                messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Back to Home", (UICommandInvokedHandler) =>
                {
                    this.Frame.Navigate(typeof(listpage));
                }));
               // messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
                await messagedialog.ShowAsync();


            }
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            x = x + 1;

            Storyboard2.Begin();
            Storyboard3.Begin();
            Storyboard4.Begin();
            Storyboard5.Begin();
            Storyboard6.Begin();
            Storyboard7.Begin();
            Storyboard8.Begin();
            Storyboard9.Begin();
            Storyboard10.Begin();
            Storyboard11.Begin();
            Storyboard12.Begin();

        }
    }


}
