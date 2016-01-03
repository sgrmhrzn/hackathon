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
    public sealed partial class Zombiescorepage : Page
    {
        public Zombiescorepage()
        {
            this.InitializeComponent();
            urscore.Text = (Zombiebackground.sa).ToString();
            Zombiebackground.sa = 0;
        }

        private void _try_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Zombiebackground));
        }

       async private void exit_Click(object sender, RoutedEventArgs e)
       
                {
                    {
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

       private void _try_Copy_Click(object sender, RoutedEventArgs e)
       {
           this.Frame.Navigate(typeof(listpage));
       }
            
        
    }
}
