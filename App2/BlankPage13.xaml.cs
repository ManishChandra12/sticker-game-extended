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
    public sealed partial class BlankPage13 : Page
    {
        Random random1 = new Random();
        public static int l,k,s,sc,kl,t,i;
        DispatcherTimer dat = new DispatcherTimer();
        public BlankPage13()
        {
            
            
             
            this.InitializeComponent();
            naam.Text = BlankPage8.s1;
            naam2.Text = BlankPage8.s2;
            t = BlankPage1.p[0];
            i = 0;
            s = 1;
            sc = 9;
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            imng1.Visibility = Visibility.Collapsed;

            imng6.Visibility = Visibility.Collapsed;

            winner.Visibility = Visibility.Collapsed;
            kl = random1.Next(0, 2);
            if (kl == 1)
            {
                btn4.IsEnabled = false;
               
            }
            else
            {
                i += 1;
                btn01.IsEnabled = false;
            }
            
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
           
            btn01.IsEnabled = true;
           
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            imng1.Visibility = Visibility.Visible;

            switch (t)
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
                    btn4.Visibility = Visibility.Collapsed;
                 
                    if(i==0 && k==t)
                    {
                        s += 1;
                        sc -= 1;
                        md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                        md.Play();
                        score.Text = Convert.ToString(s);
                        score2.Text = Convert.ToString(sc);
                    }
                    if(btn4.Visibility==Visibility.Collapsed && btn01.Visibility==Visibility.Collapsed && (s==0 || sc==0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn4.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            

        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            
            btn4.IsEnabled = true;
          
            
            imng6.Visibility = Visibility.Visible;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            int k = random1.Next(0, 5);
            switch(k)
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
            if (i==1 && k == t)
            {
                sc += 1;
                s -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            btn01.Visibility = Visibility.Collapsed;
            
            if (btn4.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn4.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed)
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
