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
    public sealed partial class BlankPage10 : Page
    {
        public BlankPage10()
        {
            this.InitializeComponent();
            if (BlankPage1.s > BlankPage1.sc)
            {
                wwinner.Text = BlankPage8.s1;
                wnnr.Source = new Uri(@"ms-appx:///Assets/winner.wav");
                wnnr.Play();
            }
            if (BlankPage1.sc > BlankPage1.s)
            {
                wnnr.Source = new Uri(@"ms-appx:///Assets/winner.wav");
                wnnr.Play();
                wwinner.Text = BlankPage8.s2;
            }
            if(BlankPage1.sc==BlankPage1.s)
            {
                wnr.Visibility = Visibility.Collapsed;
                wwinner.Text = "Game Ended In a Draw";

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dj.Source = new Uri(@"ms-appx:///Assets/button.wav");
            dj.Play();
            this.Frame.Navigate(typeof(BlankPage5));
        }

        private void Button_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ioo.Source = new Uri(@"ms-appx:///Assets/button.wav");
            ioo.Play();
        }
    }
}
