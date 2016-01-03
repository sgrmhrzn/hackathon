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
    public sealed partial class maze : Page
    {
        public maze()
        {
            this.InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mazerunner));
        }

        private async void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Windows.UI.Popups.MessageDialog msg = new Windows.UI.Popups.MessageDialog("Click the zombies as many times as possible for high score!!", "");
            await msg.ShowAsync();
        }
    }
}
