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
    public sealed partial class BlankPage5 : Page
    {
        public BlankPage5()
        {
            this.InitializeComponent();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage3));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage6));
        }

        private void button1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            jpt.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jpt.Play();
        }

        private void button2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            jpt.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jpt.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            this.Frame.Navigate(typeof(BlankPage2));
        }

        private void ext_Click(object sender, RoutedEventArgs e)
        {
            
            Application.Current.Exit();
        }

        private void Button_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            one.Source = new Uri(@"ms-appx:///Assets/button.wav");
            one.Play();
        }

        private void ext_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two.Source = new Uri(@"ms-appx:///Assets/button.wav");
            two.Play();
        }
    }
}
