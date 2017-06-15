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
    public sealed partial class BlankPage12 : Page
    {
        public BlankPage12()
        {
            this.InitializeComponent();
            if (BlankPage7.su > BlankPage7.suu)
            {
                wwinnera.Text ="COMPUTER" ;
                wnnr.Source = new Uri(@"ms-appx:///Assets/winner.wav");
                wnnr.Play();
            }
            if (BlankPage7.suu > BlankPage7.su)
            {
                wnnr.Source = new Uri(@"ms-appx:///Assets/winner.wav");
                wnnr.Play();
                wwinnera.Text = BlankPage11.ss;
            }
            if(BlankPage7.su==BlankPage7.suu)
            {
                wnr.Visibility = Visibility.Collapsed;
                wwinnera.Text = "Game Ended In a Draw";

            }

        }

        private void hmm_Click(object sender, RoutedEventArgs e)
        {
            djf.Source = new Uri(@"ms-appx:///Assets/button.wav");
            djf.Play();
            this.Frame.Navigate(typeof(BlankPage5));
        }

        private void hmm_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            nmnm.Source = new Uri(@"ms-appx:///Assets/button.wav");
            nmnm.Play();
        }
        
    }
}
