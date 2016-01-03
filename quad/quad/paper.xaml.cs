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
    public sealed partial class paper : Page
    {
        public paper()
        {
            this.InitializeComponent();
        }

        private async void b2_Click(object sender, RoutedEventArgs e)
        {
            var messagedialog = new Windows.UI.Popups.MessageDialog("Are you sure you want to exit?");
            messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Yes", (UICommandInvokedHandler) =>
            {
                Application.Current.Exit();
            }
                ));
            messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("No"));
            messagedialog.Commands.Add(new Windows.UI.Popups.UICommand("Maybe"));
            await messagedialog.ShowAsync();

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(psr));
        }

       

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.UI.Popups.MessageDialog msg = new Windows.UI.Popups.MessageDialog("Select anyone from rock,paper and scissors and see the results", "");
            await msg.ShowAsync();
        }
    }
}
