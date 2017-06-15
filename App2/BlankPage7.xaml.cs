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
    public sealed partial class BlankPage7 : Page
    {
        Random ran1 = new Random();
        public int[] r1;
        public int r2;
        public int[] r3;
        public int[] r4;
        public static int[] p;
        public static int[] q;
        public static int i,su,suu,kl,cc,dd;
        DispatcherTimer det = new DispatcherTimer();
        DispatcherTimer dett = new DispatcherTimer();
        public BlankPage7()
        {
            p = new int[5];
            q = new int[5];
            cc = -1;
            dd = -1;
            kl = ran1.Next(0, 2);
            r1 = new int[6] { 5, 6, 7, 8, 9,99};
            r3 = new int[6] { 5, 6, 7, 8, 9,99};
            r4 = new int[6] { 5, 6, 7, 8, 9,99};
            su = 5;
            suu = 5;
            this.InitializeComponent();
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            im1.Visibility = Visibility.Collapsed;
            im2.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            im4.Visibility = Visibility.Collapsed;
            im5.Visibility = Visibility.Collapsed;
            im6.Visibility = Visibility.Collapsed;
            im7.Visibility = Visibility.Collapsed;
            im8.Visibility = Visibility.Collapsed;
            im9.Visibility = Visibility.Collapsed;
            im10.Visibility = Visibility.Collapsed;
            winer.Visibility = Visibility.Collapsed;
            det.Interval = TimeSpan.FromSeconds(1);
            det.Tick += det_Tick;
            i = 0;
            p1.Text = BlankPage11.ss;
            if(kl==1)
            {
                b1.IsEnabled = false;
                b2.IsEnabled = false;
                b3.IsEnabled = false;
                b4.IsEnabled = false;
                b5.IsEnabled = false;
                det.Start();
            }
            if(kl==0)
            {
                b1.IsEnabled = true;
                b2.IsEnabled = true;
                b3.IsEnabled = true;
                b4.IsEnabled = true;
                b5.IsEnabled = true;
            }

            
        }
        //private void delay()
        //{
          //  for(int j=0;j<20000000;j++)
            //{ }
        //}

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            b1.Visibility = Visibility.Collapsed;
            im1.Visibility = Visibility.Visible;
            im2.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            im4.Visibility = Visibility.Collapsed;
            im5.Visibility = Visibility.Collapsed;
            B:
            r1[i] = ran1.Next(0, 5);
            if (i == 1 && r1[1] == r1[0])
            {
                goto B;
            }
            if (i == 2 && (r1[2] == r1[0] || r1[2] == r1[1]))
            {
                goto B;
            }
            if (i == 3 && (r1[3] == r1[0] || r1[3] == r1[1] || r1[3] == r1[2]))
            {
                goto B;
            }
            if (i == 4 && (r1[4] == r1[0] || r1[4] == r1[1] || r1[4] == r1[2] || r1[4] == r1[3]))
            {
                goto B;
            }
            
            switch (r1[i])
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
            if (i!=0 && r1[i] == r4[i-1])
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                // delay();
            }
            else
            {
                cc += 1;
                p[cc] = r1[i];
            }
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed && (su == 0 || suu == 0))
            {
                winer.Visibility = Visibility.Visible;
            }

            if (kl == 0 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                det.Start();
            }
            if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                dett.Interval = TimeSpan.FromSeconds(2);
                dett.Tick += dett_Tick;
                dett.Start();
            }
            if((kl==0 && i<=4) || (kl==1 && i<5))
            {
            det.Start();
            }
                //comp();
            

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            b2.Visibility = Visibility.Collapsed;
            b1.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            im2.Visibility = Visibility.Visible;
            im1.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            im4.Visibility = Visibility.Collapsed;
            im5.Visibility = Visibility.Collapsed;
            C:
            r1[i] = ran1.Next(0, 5);
            if (i == 1 && r1[1] == r1[0])
            {
                goto C;
            }
            if (i == 2 && (r1[2] == r1[0] || r1[2] == r1[1]))
            {
                goto C;
            }
            if (i == 3 && (r1[3] == r1[0] || r1[3] == r1[1] || r1[3] == r1[2]))
            {
                goto C;
            }
            if (i == 4 && (r1[4] == r1[0] || r1[4] == r1[1] || r1[4] == r1[2] || r1[4] == r1[3]))
            {
                goto C;
            }
            switch (r1[i])
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
            if (i!=0 && r1[i] == r4[i-1])
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                // delay();
            }
            else
            {
                cc += 1;
                p[cc] = r1[i];
            }
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed && (su == 0 || suu == 0))
            {
                winer.Visibility = Visibility.Visible;
            }

            if (kl == 0 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                det.Start();
            }
            if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                dett.Interval = TimeSpan.FromSeconds(2);
                dett.Tick += dett_Tick;
                dett.Start();
            }
            if ((kl == 0 && i <= 4) || (kl == 1 && i < 5))
            {
                det.Start();
            }
            //comp();
            

        
            //comp();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            b3.Visibility = Visibility.Collapsed;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            im3.Visibility = Visibility.Visible;
            im2.Visibility = Visibility.Collapsed;
            im1.Visibility = Visibility.Collapsed;
            im4.Visibility = Visibility.Collapsed;
            im5.Visibility = Visibility.Collapsed;
            F:
            r1[i] = ran1.Next(0, 5);
            if (i == 1 && r1[1] == r1[0])
            {
                goto F;
            }
            if (i == 2 && (r1[2] == r1[0] || r1[2] == r1[1]))
            {
                goto F;
            }
            if (i == 3 && (r1[3] == r1[0] || r1[3] == r1[1] || r1[3] == r1[2]))
            {
                goto F;
            }
            if (i == 4 && (r1[4] == r1[0] || r1[4] == r1[1] || r1[4] == r1[2] || r1[4] == r1[3]))
            {
                goto F;
            }

            switch (r1[i])
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
            if (i!=0 && r1[i] == r4[i-1])
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                // delay();
            }
            else
            {
                cc += 1;
                p[cc] = r1[i];
            }
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed && (su == 0 || suu == 0))
            {
                winer.Visibility = Visibility.Visible;
            }

            if (kl == 0 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                det.Start();
            }
            if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                dett.Interval = TimeSpan.FromSeconds(2);
                dett.Tick += dett_Tick;
                dett.Start();
            }
            if ((kl == 0 && i <= 4) || (kl == 1 && i < 5))
            {
                det.Start();
            }
       
            //comp();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            b4.Visibility = Visibility.Collapsed;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b5.IsEnabled = false;
            im4.Visibility = Visibility.Visible;
            im2.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            im1.Visibility = Visibility.Collapsed;
            im5.Visibility = Visibility.Collapsed;
            N:
            r1[i] = ran1.Next(0, 5);
            if (i == 1 && r1[1] == r1[0])
            {
                goto N;
            }
            if (i == 2 && (r1[2] == r1[0] || r1[2] == r1[1]))
            {
                goto N;
            }
            if (i == 3 && (r1[3] == r1[0] || r1[3] == r1[1] || r1[3] == r1[2]))
            {
                goto N;
            }
            if (i == 4 && (r1[4] == r1[0] || r1[4] == r1[1] || r1[4] == r1[2] || r1[4] == r1[3]))
            {
                goto N;
            }

            switch (r1[i])
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
            if (i!=0 && r1[i] == r4[i-1])
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                // delay();
            }
            else
            {
                cc += 1;
                p[cc] = r1[i];
            }
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed && (su == 0 || suu == 0))
            {
                winer.Visibility = Visibility.Visible;
            }

            if (kl == 0 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                det.Start();
            }
            if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                dett.Interval = TimeSpan.FromSeconds(2);
                dett.Tick += dett_Tick;
                dett.Start();
            }
            if ((kl == 0 && i <= 4) || (kl == 1 && i < 5))
            {
                det.Start();
            }
            //comp();
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            mm.Stop();
            tn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tn.Play();
            b5.Visibility = Visibility.Collapsed;
            b1.IsEnabled = false;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            im5.Visibility = Visibility.Visible;
            im2.Visibility = Visibility.Collapsed;
            im3.Visibility = Visibility.Collapsed;
            im4.Visibility = Visibility.Collapsed;
            im1.Visibility = Visibility.Collapsed;
            U:
            r1[i] = ran1.Next(0, 5);
            if (i == 1 && r1[1] == r1[0])
            {
                goto U;
            }
            if (i == 2 && (r1[2] == r1[0] || r1[2] == r1[1]))
            {
                goto U;
            }
            if (i == 3 && (r1[3] == r1[0] || r1[3] == r1[1] || r1[3] == r1[2]))
            {
                goto U;
            }
            if (i == 4 && (r1[4] == r1[0] || r1[4] == r1[1] || r1[4] == r1[2] || r1[4] == r1[3]))
            {
                goto U;
            }

            switch (r1[i])
            {
                case 0:
                    image5.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image5.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image5.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image5.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image5.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
                
               
            }
            if (i!=0 && r1[i] == r4[i-1])
            {
                suu += 1;
                su -= 1;
                mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                mm.Play();
                // delay();
            }
            else
            {
                cc += 1;
                p[cc] = r1[i];
            }
            p1s1.Text = Convert.ToString(suu);
            com1s1.Text = Convert.ToString(su);
            if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed && (su == 0 || suu == 0))
            {
                winer.Visibility = Visibility.Visible;
            }

            if (kl==0 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                det.Start();
            }
            if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
            {
                quit.Visibility = Visibility.Collapsed;
                dett.Interval = TimeSpan.FromSeconds(2);
                dett.Tick += dett_Tick;
                dett.Start();
            }
            if ((kl == 0 && i <= 4) || (kl == 1 && i < 5))
            {
                det.Start();
            }
            //comp();

        }
        //private void comp()
        void det_Tick(object sender, object e)
        {
           // delay();
            det.Stop();
            tntn.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            tntn.Play();

            //for(;i<5;)
           // {
            A:
                r3[i] = ran1.Next(0, 5);
                if (i==1 && r3[1] == r3[0])
                {
                    goto A;
                }
                if(i==2 && (r3[2] == r3[0] || r3[2] == r3[1]) )
                {
                    goto A;
                }
                if(i==3 && (r3[3] == r3[0] || r3[3] == r3[1] || r3[3] == r3[2]))
                {
                    goto A;
                }
                if(i==4 && (r3[4] == r3[0] || r3[4] == r3[1] || r3[4] == r3[2] || r3[4] == r3[3]))
                {
                    goto A;
                }
            L:
                r4[i] = ran1.Next(0, 5);
                if (i == 1 && r4[1] == r4[0])
                {
                    goto L;
                }
                if (i == 2 && (r4[2] == r4[0] || r4[2] == r4[1]))
                {
                    goto L;
                }
                if (i == 3 && (r4[3] == r4[0] || r4[3] == r4[1] || r4[3] == r4[2]))
                {
                    goto L;
                }
                if (i == 4 && (r4[4] == r4[0] || r4[4] == r4[1] || r4[4] == r4[2] || r4[4] == r4[3]))
                {
                    goto L;
                }
                switch (r3[i])
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
                        im8.Visibility = Visibility.Collapsed;
                        im9.Visibility = Visibility.Collapsed;
                        im10.Visibility = Visibility.Collapsed;
                       
                       
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
                        im8.Visibility = Visibility.Collapsed;
                        im9.Visibility = Visibility.Collapsed;
                        im10.Visibility = Visibility.Collapsed;
                     
  
                       
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
                        im9.Visibility = Visibility.Collapsed;
                        im10.Visibility = Visibility.Collapsed;
                        
                        break;
                       
                    case 3:
                        if (r4[i] == 0)
                        {
                            image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                        }
                        if (r4[i] == 1)
                        {
                            image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                        }
                        if (r4[i] == 2)
                        {
                            image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                        }
                        if (r4[i] == 3)
                        {
                            image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                        }
                        if (r4[i] == 4)
                        {
                            image9.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                        }
                        im9.Visibility = Visibility.Visible;
                        im7.Visibility = Visibility.Collapsed;
                        im8.Visibility = Visibility.Collapsed;
                        im6.Visibility = Visibility.Collapsed;
                        im10.Visibility = Visibility.Collapsed;
                       
                        break;
                       
                    case 4:
                        if (r4[i] == 0)
                        {
                            image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                        }
                        if (r4[i] == 1)
                        {
                            image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                        }
                        if (r4[i] == 2)
                        {
                            image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                        }
                        if (r4[i] == 3)
                        {
                            image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                        }
                        if (r4[i] == 4)
                        {
                            image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                        }
                        im10.Visibility = Visibility.Visible;
                        im7.Visibility = Visibility.Collapsed;
                        im8.Visibility = Visibility.Collapsed;
                        im9.Visibility = Visibility.Collapsed;
                        im6.Visibility = Visibility.Collapsed;
                       
                       
                        break;

                }
                if (r1[i] == r4[i])
                {
                    su += 1;
                    suu -= 1;
                    mm.Source = new Uri(@"ms-appx:///Assets/match.wav");
                    mm.Play();
                   // delay();
                }
                else
                {
                    dd += 1;
                    q[dd] = r4[i];
                }
                com1s1.Text = Convert.ToString(su);
                p1s1.Text = Convert.ToString(suu);
                
                b1.IsEnabled = true;
                b2.IsEnabled = true;
                b3.IsEnabled = true;
                b4.IsEnabled = true;
                b5.IsEnabled = true;
                if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed)
                {
                    winer.Visibility = Visibility.Visible;
                    quit.Visibility = Visibility.Collapsed;
                }
                if (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed && (su == 0 || suu == 0))
                {
                    winer.Visibility = Visibility.Visible;
                }

                if (kl == 1 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
                {
                    quit.Visibility = Visibility.Collapsed;
                    
                }
                if (kl == 0 && (b1.Visibility == Visibility.Collapsed && b2.Visibility == Visibility.Collapsed && b3.Visibility == Visibility.Collapsed && b4.Visibility == Visibility.Collapsed && b5.Visibility == Visibility.Collapsed))
                {
                    quit.Visibility = Visibility.Collapsed;
                    dett.Interval = TimeSpan.FromSeconds(2);
                    dett.Tick += dett_Tick;
                    dett.Start();
                }
               
                
                



            
            i += 1;
        }
        void dett_Tick(object sender, object e)
        {
            dett.Stop();
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

