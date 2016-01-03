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
    public sealed partial class smash : Page
    {
        public smash()
        {
            this.InitializeComponent();
        }

        private void Button_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(smashgamepage));
        }

        private async void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Windows.UI.Popups.MessageDialog msg = new Windows.UI.Popups.MessageDialog("Type as fast as you can for high score!!", "");
            await msg.ShowAsync();
        }
    }
}
