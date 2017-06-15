﻿using System;
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
    public sealed partial class BlankPage16 : Page
    {
        Random random1 = new Random();
        public static int l, s, sc, i,kl,r;
        public int[] k;
        public int[] g;
        DispatcherTimer dat = new DispatcherTimer();
        public BlankPage16()
        {
            
            k = new int[4];
            g = new int[5];
                       
            
            
            this.InitializeComponent();
            i = 0;
            k = new int[4] { 7, 8, 9, 99 };
            g[4] = 78;
            r = random1.Next(0, 4);
            if (r == 0)
            {
                g[0] = BlankPage1.p[0];
                g[1] = BlankPage1.p[1];
                g[2] = BlankPage1.p[2];
                g[3] = BlankPage1.p[3];

            }
            if (r == 1)
            {
                g[0] = BlankPage1.p[1];
                g[1] = BlankPage1.p[2];
                g[2] = BlankPage1.p[0];
                g[3] = BlankPage1.p[3];

            }
            if (r == 2)
            {
                g[0] = BlankPage1.p[2];
                g[1] = BlankPage1.p[0];
                g[2] = BlankPage1.p[1];
                g[3] = BlankPage1.p[3];

            }
            if (r == 3)
            {
                g[0] = BlankPage1.p[3];
                g[1] = BlankPage1.p[0];
                g[2] = BlankPage1.p[1];
                g[3] = BlankPage1.p[2];

            }
            naam.Text = BlankPage8.s1;
            naam2.Text = BlankPage8.s2;
            s = 4;
            sc = 6;
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            imng1.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Collapsed;
            imng3.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Collapsed;

            imng6.Visibility = Visibility.Collapsed;
            imng7.Visibility = Visibility.Collapsed;
            imng8.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Collapsed;

            winner.Visibility = Visibility.Collapsed;
            kl = random1.Next(0, 2);
            if (kl == 1)
            {
                btn4.IsEnabled = false;
                btn6.IsEnabled = false;
                btn1.IsEnabled = false;
                btn10.IsEnabled = false;
            }
            else
            {
                btn01.IsEnabled = false;
                btn02.IsEnabled = false;
                btn03.IsEnabled = false;
                btn04.IsEnabled = false;
            }
           
                
            
           
                
            
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            btn6.IsEnabled = false;
            btn1.IsEnabled = false;
            btn10.IsEnabled = false;
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            imng1.Visibility = Visibility.Visible;
            imng2.Visibility = Visibility.Collapsed;
            imng3.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Collapsed;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            g[i] = BlankPage1.p[0];

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
                    btn4.Visibility = Visibility.Collapsed;
                   
                    if (i!=0 && (g[i] == k[i - 1]))
                    {
                        s += 1;
                        sc -= 1;
                        score.Text = Convert.ToString(s);
                        score2.Text = Convert.ToString(sc);
                        md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                        md.Play();
                    }
                    if(btn1.Visibility==Visibility.Collapsed && btn4.Visibility==Visibility.Collapsed && btn6.Visibility==Visibility.Collapsed && btn10.Visibility==Visibility.Collapsed && btn01.Visibility==Visibility.Collapsed && btn02.Visibility==Visibility.Collapsed && btn03.Visibility==Visibility.Collapsed && btn04.Visibility==Visibility.Collapsed && (s==0 || sc==0))
            {
                winner.Visibility = Visibility.Visible;
            }
                    if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
                    {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

            
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            btn10.IsEnabled = false;
            btn1.IsEnabled = false;
            btn4.IsEnabled = false;
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            imng1.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Visible;
            imng3.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Collapsed;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            g[i] = BlankPage1.p[1];
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
                     
                    btn6.Visibility = Visibility.Collapsed;
                   
                    if (i!=0 && g[i] == k[i - 1])
                    {
                        s += 1;
                        sc -= 1;
                        score.Text = Convert.ToString(s);
                        score2.Text = Convert.ToString(sc);
                        md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                        md.Play();
                    }
                     if(btn1.Visibility==Visibility.Collapsed && btn4.Visibility==Visibility.Collapsed && btn6.Visibility==Visibility.Collapsed && btn10.Visibility==Visibility.Collapsed && btn01.Visibility==Visibility.Collapsed && btn02.Visibility==Visibility.Collapsed && btn03.Visibility==Visibility.Collapsed && btn04.Visibility==Visibility.Collapsed && (s==0 || sc==0))
            {
                winner.Visibility = Visibility.Visible;
            }
                    if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
                    {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

            
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn6.IsEnabled = false;
            btn10.IsEnabled = false;
            btn4.IsEnabled = false;
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            imng1.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Collapsed;
            imng3.Visibility = Visibility.Visible;
            imng4.Visibility = Visibility.Collapsed;
           
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            g[i] = BlankPage1.p[2];
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
                    
                    btn1.Visibility = Visibility.Collapsed;
                   
                    if (i!=0 && g[i] == k[i - 1])
                    {
                        s += 1;
                        sc -= 1;
                        score.Text = Convert.ToString(s);
                        score2.Text = Convert.ToString(sc);
                        md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                        md.Play();
                    }
                     if(btn1.Visibility==Visibility.Collapsed && btn4.Visibility==Visibility.Collapsed && btn6.Visibility==Visibility.Collapsed && btn10.Visibility==Visibility.Collapsed && btn01.Visibility==Visibility.Collapsed && btn02.Visibility==Visibility.Collapsed && btn03.Visibility==Visibility.Collapsed && btn04.Visibility==Visibility.Collapsed && (s==0 || sc==0))
            {
                winner.Visibility = Visibility.Visible;
            }
                    if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
                    {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

            
        }
        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            btn6.IsEnabled = false;
            btn1.IsEnabled = false;
            btn4.IsEnabled = false;
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            imng1.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Collapsed;
            imng3.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Visible;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            g[i] = BlankPage1.p[3];
            switch (g[i])
            {
                case 0:
                    image4.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image4.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image4.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image4.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image4.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
                   
                    btn10.Visibility = Visibility.Collapsed;
                    
                    if (i!=0 && g[i] == k[i - 1])
                    {
                        s += 1;
                        sc -= 1;
                        score.Text = Convert.ToString(s);
                        score2.Text = Convert.ToString(sc);
                        md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                        md.Play();
                    }
                     if(btn1.Visibility==Visibility.Collapsed && btn4.Visibility==Visibility.Collapsed && btn6.Visibility==Visibility.Collapsed && btn10.Visibility==Visibility.Collapsed && btn01.Visibility==Visibility.Collapsed && btn02.Visibility==Visibility.Collapsed && btn03.Visibility==Visibility.Collapsed && btn04.Visibility==Visibility.Collapsed && (s==0 || sc==0))
            {
                winner.Visibility = Visibility.Visible;
            }
                    if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
                    {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

            
        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
            btn04.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            imng7.Visibility = Visibility.Collapsed;
            imng6.Visibility = Visibility.Visible;
            imng8.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Collapsed;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            nh:
            k[i] = random1.Next(0, 5);
            if (i == 1 && k[1] == k[0])
            {
                goto nh;
            }
            if (i == 2 && (k[2] == k[0] || k[2] == k[1]))
            {
                goto nh;
            }
            if (i == 3 && (k[3] == k[0] || k[3] == k[1] || k[3]==k[2]))
            {
                goto nh;
            }
            switch (k[i])
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
            if (kl == 0 && i == 0 && k[i] == g[i])
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
                sc += 1;
                s -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            btn01.Visibility = Visibility.Collapsed;
           
            i += 1;
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
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
            btn03.IsEnabled = false;
            btn04.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            imng7.Visibility = Visibility.Visible;
            imng6.Visibility = Visibility.Collapsed;
            imng8.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Collapsed;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
        bcd:
            k[i] = random1.Next(0, 5);
            if (i == 1 && k[1] == k[0])
            {
                goto bcd;
            }
            if (i == 2 && (k[2] == k[0] || k[2] == k[1]))
            {
                goto bcd;
            }
            if (i == 3 && (k[3] == k[0] || k[3] == k[1] || k[3] == k[2]))
            {
                goto bcd;
            }
            switch (k[i])
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
            if (kl == 0 && i == 0 && k[i] == g[i])
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
                sc += 1;
                s -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            
            btn02.Visibility = Visibility.Collapsed;
           
            i += 1;
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }


        }

        private void btn03_Click(object sender, RoutedEventArgs e)
        {
            btn02.IsEnabled = false;
            btn01.IsEnabled = false;
            btn04.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            imng7.Visibility = Visibility.Collapsed;
            imng6.Visibility = Visibility.Collapsed;
            imng8.Visibility = Visibility.Visible;
            imng9.Visibility = Visibility.Collapsed;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
        efg:
            k[i] = random1.Next(0, 5);
            if (i == 1 && k[1] == k[0])
            {
                goto efg;
            }
            if (i == 2 && (k[2] == k[0] || k[2] == k[1]))
            {
                goto efg;
            }
            if (i == 3 && (k[3] == k[0] || k[3] == k[1] || k[3] == k[2]))
            {
                goto efg;
            }
            switch (k[i])
            {
                case 0:
                    image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image8.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
            if (kl == 0 && i == 0 && k[i] == g[i])
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
                sc += 1;
                s -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
           
            btn03.Visibility = Visibility.Collapsed;
           
            i += 1;
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }


        }

        private void btn04_Click(object sender, RoutedEventArgs e)
        {
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
            btn01.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            imng7.Visibility = Visibility.Collapsed;
            imng6.Visibility = Visibility.Collapsed;
            imng8.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Visible;
            
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
        ef:
            k[i] = random1.Next(0, 5);
            if (i == 1 && k[1] == k[0])
            {
                goto ef;
            }
            if (i == 2 && (k[2] == k[0] || k[2] == k[1]))
            {
                goto ef;
            }
            if (i == 3 && (k[3] == k[0] || k[3] == k[1] || k[3] == k[2]))
            {
                goto ef;
            }
            switch (k[i])
            {
                case 0:
                    image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
            }
            if (kl == 0 && i == 0 && k[i] == g[i])
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
                sc += 1;
                s -= 1;
                score.Text = Convert.ToString(s);
                score2.Text = Convert.ToString(sc);
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
           
            btn04.Visibility = Visibility.Collapsed;
           
            i += 1;
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed)
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
