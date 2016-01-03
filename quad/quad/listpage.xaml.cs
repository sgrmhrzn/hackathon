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
    public sealed partial class listpage : Page
    {
        public listpage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(fastrack));
        }

        private void zombie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Zombiemainpage));
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(fastrack));
        }

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Zombiemainpage));
        }

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(paper));
        }

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Image_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
           
        }

        private void Image_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(maze));
        }

        private void Image_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(smash));
        }
    }
}
