﻿using System;
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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(listpage));
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
