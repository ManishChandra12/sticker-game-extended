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

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage6 : Page
    {
        public BlankPage6()
        {
            this.InitializeComponent();
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            ndz.Source = new Uri(@"ms-appx:///Assets/button.wav");
            ndz.Play();
            this.Frame.Navigate(typeof(BlankPage8));
        }

        private void single_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage7));
        }

        private void single_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            jpn.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jpn.Play();
        }

        private void two_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            jpn.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jpn.Play();
        }

        

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage5));
        }

        private void hehe_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage11));
        }

        private void hehe_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            jpnt.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jpnt.Play();
        }
    }
}
