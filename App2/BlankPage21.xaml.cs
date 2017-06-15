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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage21 : Page
    {
        Random random1 = new Random();
        public static int l, k, suu, su, kl;
        DispatcherTimer dat = new DispatcherTimer();
        DispatcherTimer det = new DispatcherTimer();
        public BlankPage21()
        {



            this.InitializeComponent();
            p1.Text = BlankPage11.ss;
            

            suu = 1;
            su = 9;
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            im1.Visibility = Visibility.Collapsed;

            im6.Visibility = Visibility.Collapsed;

            winer.Visibility = Visibility.Collapsed;
            kl = random1.Next(0, 2);
            if (kl == 1)
            {
                b1.IsEnabled = false;
                dat.Interval = TimeSpan.FromSeconds(1);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            else
            {
                b1.IsEnabled = true;
            }

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {

           

            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            im1.Visibility = Visibility.Visible;
            
            

            switch (BlankPage7.p[0])
            {
                case 0:
                    image1.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image1.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image1.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image1.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image1.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
            b1.Visibility = Visibility.Collapsed;

            if (k == BlankPage7.p[0])
            {
                suu += 1;
                su-= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                p1s1.Text = Convert.ToString(suu);
                com1s1.Text = Convert.ToString(su);
            }
            if (b1.Visibility == Visibility.Collapsed && (suu == 0 || su == 0))
            {
                winer.Visibility = Visibility.Visible;
            }
            if (kl==1 && b1.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                det.Interval = TimeSpan.FromSeconds(2);
                det.Tick += det_Tick;
                det.Start();
            }
            if(kl==0 && b1.Visibility == Visibility.Collapsed)
            {
                dat.Interval = TimeSpan.FromSeconds(1);
                dat.Tick += dat_Tick;
                dat.Start();
            }

        }

        void dat_Tick(object sender, object e)
        {
            // delay();
            dat.Stop();
            tntn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tntn.Play();


            b1.IsEnabled = true;

            if(kl==0)
            {
                im1.Visibility = Visibility.Visible;
            }
            im6.Visibility = Visibility.Visible;

            int k = random1.Next(0, 5);
            switch (k)
            {
                case 0:
                    image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
            if (k == BlankPage7.p[0])
            {
                su += 1;
                suu -= 1;
                p1s1.Text = Convert.ToString(suu);
                com1s1.Text = Convert.ToString(su);
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
            }
           
            if (b1.Visibility == Visibility.Collapsed && (suu == 0 || su == 0))
            {
                winer.Visibility = Visibility.Visible;
            }
            if (b1.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                det.Interval = TimeSpan.FromSeconds(2);
                det.Tick += dat_Tick;
                det.Start();
            }

        }
        void det_Tick(object sender, object e)
        {
            det.Stop();
            if (suu == 1)
            {
                this.Frame.Navigate(typeof(BlankPage21));
            }
            if (suu == 2)
            {
                this.Frame.Navigate(typeof(BlankPage22));
            }
            if (suu == 3)
            {
                this.Frame.Navigate(typeof(BlankPage23));
            }
            if (suu == 4)
            {
                this.Frame.Navigate(typeof(BlankPage24));
            }
            if (suu == 5)
            {
                this.Frame.Navigate(typeof(BlankPage7));
            }
            if (su == 1)
            {
                this.Frame.Navigate(typeof(BlankPage25));
            }
            if (su == 2)
            {
                this.Frame.Navigate(typeof(BlankPage26));
            }
            if (su == 3)
            {
                this.Frame.Navigate(typeof(BlankPage27));
            }
            if (su == 4)
            {
                this.Frame.Navigate(typeof(BlankPage28));
            }

        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage6));
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            nnnn.Source = new Uri(@"ms-appx:///Assets/button.wav");
            nnnn.Play();
            this.Frame.Navigate(typeof(BlankPage5));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            jdos.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jdos.Play();
            this.Frame.Navigate(typeof(BlankPage12));
        }

        private void quit_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            npnm.Source = new Uri(@"ms-appx:///Assets/button.wav");
            npnm.Play();
        }

        private void winer_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            sp.Source = new Uri(@"ms-appx:///Assets/button.wav");
            sp.Play();
        }



    }
}

