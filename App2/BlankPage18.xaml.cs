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
    public sealed partial class BlankPage18 : Page
    {
        Random random1 = new Random();
        public static int l, s, sc, i,kl,r;
        public int[] k;
        public int[] g;
        DispatcherTimer dat = new DispatcherTimer();
        public BlankPage18()
        {
           
            k = new int[2];
            g = new int[3];
           
            
            
            this.InitializeComponent();
            g[2] = 445;
            r = random1.Next(0, 2);
            if (r == 0)
            {
                g[0] = BlankPage1.q[0];
                g[1] = BlankPage1.q[1];
               

            }
            if (r == 1)
            {
                g[0] = BlankPage1.q[1];
                g[1] = BlankPage1.q[0];
               

            }
           
            k = new int[2] { 9, 99 };
            
            i = 0;
            naam.Text = BlankPage8.s1;
            naam2.Text = BlankPage8.s2;
            s = 8;
            sc = 2;
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            imng1.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Collapsed;

            imng6.Visibility = Visibility.Collapsed;
            imng7.Visibility = Visibility.Collapsed;

            winner.Visibility = Visibility.Collapsed;
            kl = random1.Next(0, 2);
            if (kl == 1)
            { 
                 btn4.IsEnabled = false;
                btn6.IsEnabled = false;
            }
            else
            {
                btn01.IsEnabled = false;
                btn02.IsEnabled = false;
            }
           
                
           
               
            
        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            btn02.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            
            imng7.Visibility = Visibility.Collapsed;
            imng6.Visibility = Visibility.Visible;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            g[i] = BlankPage1.q[0];

            switch (g[i])
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
                    btn01.Visibility = Visibility.Collapsed;
                   
                    if (i!=0 && (g[i] == k[i - 1]))
                    {
                        sc += 1;
                        s -= 1;
                        score.Text = Convert.ToString(s);
                        score2.Text = Convert.ToString(sc);
                        md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                        md.Play();
                    }
                     if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

            
        }

        private void btn02_Click(object sender, RoutedEventArgs e)
        {
            btn01.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            imng7.Visibility = Visibility.Visible;
            imng6.Visibility = Visibility.Collapsed;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            g[i] = BlankPage1.q[1];
            switch (g[i])
            {
                case 0:
                    image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image7.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
                    
                    btn02.Visibility = Visibility.Collapsed;
                   
                    if (i!=0 && g[i] == k[i - 1])
                    {
                        sc += 1;
                        s -= 1;
                        score.Text = Convert.ToString(s);
                        score2.Text = Convert.ToString(sc);
                        md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                        md.Play();
                    }
                     if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

            
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            btn6.IsEnabled = false;
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            imng1.Visibility = Visibility.Visible;
            imng2.Visibility = Visibility.Collapsed;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
        abcg:
            k[i] = random1.Next(0, 5);
            if (i == 1 && k[1] == k[0])
            {
                goto abcg;
            }
           
            switch (k[i])
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
            if (kl == 1 && i == 0 && k[i] == g[i])
            {
                s += 1;
                sc -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            if (i>0 && k[i] == g[i])
            {
                s += 1;
                sc -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            btn4.Visibility = Visibility.Collapsed;
           
            i += 1;
            if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            btn4.IsEnabled = false;
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            imng1.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Visible;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
        abc:
            k[i] = random1.Next(0, 5);
            if (i == 1 && k[1] == k[0])
            {
                goto abc;
            }
            switch (k[i])
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
            if (kl == 1 && i == 0 && k[i] == g[i])
            {
                s += 1;
                sc -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            if (i>0 && k[i] == g[i])
            {
                s += 1;
                sc -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
           
            btn6.Visibility = Visibility.Collapsed;
           
            i += 1;
            if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }


        }
        void dat_Tick(object sender, object e)
        {
            dat.Stop();
            if (s == 1)
            {
                this.Frame.Navigate(typeof(BlankPage13));
            }
            if (s == 2)
            {
                this.Frame.Navigate(typeof(BlankPage14));
            }
            if (s == 3)
            {
                this.Frame.Navigate(typeof(BlankPage15));
            }
            if (s == 4)
            {
                this.Frame.Navigate(typeof(BlankPage16));
            }
            if (s == 5)
            {
                this.Frame.Navigate(typeof(BlankPage1));
            }
            if (sc == 1)
            {
                this.Frame.Navigate(typeof(BlankPage17));
            }
            if (sc == 2)
            {
                this.Frame.Navigate(typeof(BlankPage18));
            }
            if (sc == 3)
            {
                this.Frame.Navigate(typeof(BlankPage19));
            }
            if (sc == 4)
            {
                this.Frame.Navigate(typeof(BlankPage20));
            }

        }
        private void quit_Click(object sender, RoutedEventArgs e)
        {
            nnn.Source = new Uri(@"ms-appx:///Assets/button.wav");
            nnn.Play();
            this.Frame.Navigate(typeof(BlankPage5));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage6));
        }

        private void winner_Click(object sender, RoutedEventArgs e)
        {
            jd.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jd.Play();
            this.Frame.Navigate(typeof(BlankPage10));
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage6));
        }

        private void quit_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            kk.Source = new Uri(@"ms-appx:///Assets/button.wav");
            kk.Play();
        }

        private void winner_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            ips.Source = new Uri(@"ms-appx:///Assets/button.wav");
            ips.Play();
        }

    }
}
