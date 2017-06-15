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
    public sealed partial class BlankPage9 : Page
    {
         DispatcherTimer dat = new DispatcherTimer();
        public BlankPage9()
        {
            this.InitializeComponent();
            sng.Source = new Uri(@"ms-appx:///Assets/start1.wav");
            sng.Play();
            dat.Interval = TimeSpan.FromSeconds(5);
            dat.Tick += dat_Tick;
            dat.Start();
        }
        void dat_Tick(object sender,object e)
        {
            dat.Stop();
           // present.Visibility = Visibility.Visible;
            this.Frame.Navigate(typeof(BlankPage5));
        }

        
        
    }
}
