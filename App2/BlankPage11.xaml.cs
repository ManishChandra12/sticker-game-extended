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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage11 : Page
    {
        public static string ss;
        public BlankPage11()
        {
            this.InitializeComponent();

        }

       
        async private void bb_Click_1(object sender, RoutedEventArgs e)
        {

            MessageDialog error = new MessageDialog("Player name missing! Try Again!");
            if (namehe.Text == "")
            {
                await error.ShowAsync();
            }
            else
            {

                ss = namehe.Text;

                this.Frame.Navigate(typeof(BlankPage7));
            }
        }

        private void bb_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            jpt12.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jpt12.Play();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage6));
        }
    }
}

