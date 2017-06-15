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
    public sealed partial class BlankPage27 : Page
    {
        Random random1 = new Random();
        public static int l, suu, k, su, kl, i;
        public int[] g;
        public int[] km;
        public int[] r4;

        DispatcherTimer dat = new DispatcherTimer();
        DispatcherTimer det = new DispatcherTimer();
        public BlankPage27()
        {
            r4 = new int[6] { 5, 6, 7, 8, 9, 99 };
            km = new int[3];
            g = new int[4];
            i = 0;
            this.InitializeComponent();
            p1.Text = BlankPage11.ss;
           
            suu = 7;
            su = 3;
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            im1.Visibility = Visibility.Collapsed;
            im2.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            im8.Visibility = Visibility.Collapsed;
            im7.Visibility = Visibility.Collapsed;

            im6.Visibility = Visibility.Collapsed;

            winer.Visibility = Visibility.Collapsed;
            kl = random1.Next(0, 2);
            if (kl == 1)
            {
                b1.IsEnabled = false;
                b3.IsEnabled = false;
                b2.IsEnabled = false;
                dat.Interval = TimeSpan.FromSeconds(1);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            else
            {
                b1.IsEnabled = true;
                b2.IsEnabled = true;
                b3.IsEnabled = true;
            }

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            b2.IsEnabled = false;
            b3.IsEnabled = false;


            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            im1.Visibility = Visibility.Visible;
            im2.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;

            g[i] = BlankPage7.q[0];
            switch (g[i])
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

            if (i != 0 && (g[i] == r4[i - 1]))
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                p1s1.Text = Convert.ToString(suu);
                com1s1.Text = Convert.ToString(su);
            }
            if (kl == 1 && b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && (suu == 0 || su == 0))
            {
                winer.Visibility = Visibility.Visible;
            }
            if (kl == 1 && b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                det.Interval = TimeSpan.FromSeconds(2);
                det.Tick += det_Tick;
                det.Start();
            }
            if ((kl == 0 && i <= 2) || (kl == 1 && i < 3))
            {
                dat.Interval = TimeSpan.FromSeconds(1);
                dat.Tick += dat_Tick;
                dat.Start();
            }
           


        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            b3.IsEnabled = false;


            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            im2.Visibility = Visibility.Visible;
            im1.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            g[i] = BlankPage7.q[1];
            switch (g[i])
            {
                case 0:
                    image2.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image2.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image2.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image2.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image2.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
            b2.Visibility = Visibility.Collapsed;

            if (i != 0 && (g[i] == r4[i - 1]))
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                p1s1.Text = Convert.ToString(suu);
                com1s1.Text = Convert.ToString(su);
            }
            if (kl == 1 && b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && (suu == 0 || su == 0))
            {
                winer.Visibility = Visibility.Visible;
            }
           
            if ((kl == 0 && i <= 2) || (kl == 1 && i < 3))
            {
                dat.Interval = TimeSpan.FromSeconds(1);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                det.Interval = TimeSpan.FromSeconds(2);
                det.Tick += det_Tick;
                det.Start();
            }
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            b2.IsEnabled = false;


            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            im2.Visibility = Visibility.Visible;
            im1.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            g[i] = BlankPage7.q[2];
            switch (g[i])
            {
                case 0:
                    image3.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image3.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image3.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image3.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image3.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
            b3.Visibility = Visibility.Collapsed;

            if (i != 0 && (g[i] == r4[i - 1]))
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                p1s1.Text = Convert.ToString(suu);
                com1s1.Text = Convert.ToString(su);
            }
            if (kl == 1 && b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && (suu == 0 || su == 0))
            {
                winer.Visibility = Visibility.Visible;
            }
            if (kl == 1 && b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                det.Interval = TimeSpan.FromSeconds(2);
                det.Tick += det_Tick;
                det.Start();
            }
            if ((kl == 0 && i <= 2) || (kl == 1 && i < 3))
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

            //for(;i<5;)
        // {
        A:
            km[i] = random1.Next(0, 3);
            if (i == 1 && km[1] == km[0])
            {
                goto A;
            }
            if (i == 2 && (km[2] == km[0] || km[2] == km[1]))
            {
                goto A;
            }

        L:
            r4[i] = random1.Next(0, 5);
            if (i == 1 && r4[1] == r4[0])
            {
                goto L;
            }
            if (i == 2 && (r4[2] == r4[0] || r4[2] == r4[1]))
            {
                goto L;
            }

            switch (km[i])
            {
                case 0:

                    if (r4[i] == 0)
                    {
                        image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    }
                    if (r4[i] == 1)
                    {
                        image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    }
                    if (r4[i] == 2)
                    {
                        image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    }
                    if (r4[i] == 3)
                    {
                        image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    }
                    if (r4[i] == 4)
                    {
                        image6.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    }
                    im6.Visibility = Visibility.Visible;
                    im7.Visibility = Visibility.Collapsed;



                    break;
                case 1:


                    if (r4[i] == 0)
                    {
                        image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    }
                    if (r4[i] == 1)
                    {
                        image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    }
                    if (r4[i] == 2)
                    {
                        image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    }
                    if (r4[i] == 3)
                    {
                        image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    }
                    if (r4[i] == 4)
                    {
                        image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    }
                    im7.Visibility = Visibility.Visible;
                    im6.Visibility = Visibility.Collapsed;




                    break;
                case 2:
                    if (r4[i] == 0)
                    {
                        image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    }
                    if (r4[i] == 1)
                    {
                        image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    }
                    if (r4[i] == 2)
                    {
                        image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    }
                    if (r4[i] == 3)
                    {
                        image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    }
                    if (r4[i] == 4)
                    {
                        image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    }
                    im8.Visibility = Visibility.Visible;
                    im7.Visibility = Visibility.Collapsed;

                    im6.Visibility = Visibility.Collapsed;


                    break;


            }
            if (g[i] == r4[i])
            {
                su += 1;
                suu -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                // delay();
            }
            com1s1.Text = Convert.ToString(su);
            p1s1.Text = Convert.ToString(suu);

            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
           
            if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed)
            {
                winer.Visibility = Visibility.Visible;
                quit.Visibility = Visibility.Collapsed;
            }
            if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && (su == 0 || suu == 0))
            {
                winer.Visibility = Visibility.Visible;
            }

            if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;

            }
            if (kl == 0 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                det.Interval = TimeSpan.FromSeconds(2);
                det.Tick += det_Tick;
                det.Start();
            }







            i += 1;
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

