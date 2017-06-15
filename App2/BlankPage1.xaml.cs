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
    public sealed partial class BlankPage1 : Page
    {
        Random random1 = new Random();
        public int[] randomNumber2;
        public int[] randomNumber1;
        public static int[] p;
        public static int[] q;
        public static int s,cc,dd, sc,i,k;
        DispatcherTimer dat = new DispatcherTimer();

        public BlankPage1()
        {
            cc = -1;
            dd = -1;
            p = new int[5];
            q = new int[5];
            k = random1.Next(0, 2);
            randomNumber2 = new int[6] { 5, 6, 7, 8,9,10};
            randomNumber1 = new int[5] { 15, 16, 17, 18, 19 };
            s = 5;
            sc = 5;
            this.InitializeComponent();
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            naam.Text = BlankPage8.s1;
            naam2.Text = BlankPage8.s2;
            i = 0;
            if (k == 0)
            {
                btn01.IsEnabled = false;
                btn02.IsEnabled = false;
                btn03.IsEnabled = false;
                btn04.IsEnabled = false;
                btn05.IsEnabled = false;
                imng1.Visibility = Visibility.Collapsed;
                imng2.Visibility = Visibility.Collapsed;
                imng3.Visibility = Visibility.Collapsed;
                imng4.Visibility = Visibility.Collapsed;
                imng5.Visibility = Visibility.Collapsed;
                imng6.Visibility = Visibility.Collapsed;
                imng7.Visibility = Visibility.Collapsed;
                imng8.Visibility = Visibility.Collapsed;
                imng9.Visibility = Visibility.Collapsed;
                imng10.Visibility = Visibility.Collapsed;
                winner.Visibility = Visibility.Collapsed;
              
            }
            if (k == 1)
            {
                btn4.IsEnabled = false;
                btn6.IsEnabled = false;
                btn1.IsEnabled = false;
                btn10.IsEnabled = false;
                button11.IsEnabled = false;
                imng1.Visibility = Visibility.Collapsed;
                imng2.Visibility = Visibility.Collapsed;
                imng3.Visibility = Visibility.Collapsed;
                imng4.Visibility = Visibility.Collapsed;
                imng5.Visibility = Visibility.Collapsed;
                imng6.Visibility = Visibility.Collapsed;
                imng7.Visibility = Visibility.Collapsed;
                imng8.Visibility = Visibility.Collapsed;
                imng9.Visibility = Visibility.Collapsed;
                imng10.Visibility = Visibility.Collapsed;
                winner.Visibility = Visibility.Collapsed;
               
            }
           
        }
  
         
       
       
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            btn05.IsEnabled = true;
            btn4.IsEnabled = false;
            btn6.IsEnabled = false;
            btn1.IsEnabled = false;
            btn10.IsEnabled = false;
            button11.IsEnabled = false;
            imng1.Visibility = Visibility.Visible;
            imng2.Visibility = Visibility.Collapsed;
            imng3.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Collapsed;
            imng5.Visibility = Visibility.Collapsed;
            ER:
            randomNumber2[i] = random1.Next(0, 5);
            if (i == 1 && randomNumber2[1] == randomNumber2[0])
            {
                goto ER;
            }
            if (i == 2 && (randomNumber2[2] == randomNumber2[0] || randomNumber2[2] == randomNumber2[1]))
            {
                goto ER;
            }
            if (i == 3 && (randomNumber2[3] == randomNumber2[0] || randomNumber2[3] == randomNumber2[1] || randomNumber2[3] == randomNumber2[2]))
            {
                goto ER;
            }
            if (i == 4 && (randomNumber2[4] == randomNumber2[0] || randomNumber2[4] == randomNumber2[1] || randomNumber2[4] == randomNumber2[2] || randomNumber2[4] == randomNumber2[3]))
            {
                goto ER;
            }
            if (i == 5 && (randomNumber2[5] == randomNumber2[0] || randomNumber2[5] == randomNumber2[1] || randomNumber2[5] == randomNumber2[2] || randomNumber2[5] == randomNumber2[3] || randomNumber2[5] == randomNumber2[4]))
            {
                goto ER;
            }
            switch (randomNumber2[i])
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
            
            if (i!=0 && randomNumber1[i-1] == randomNumber2[i])
            {
                s +=1;
                sc -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                cc += 1;
                p[cc] = randomNumber2[i];
            }
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            if(btn1.Visibility==Visibility.Collapsed && btn4.Visibility==Visibility.Collapsed && btn6.Visibility==Visibility.Collapsed && btn10.Visibility==Visibility.Collapsed && button11.Visibility==Visibility.Collapsed && btn01.Visibility==Visibility.Collapsed && btn02.Visibility==Visibility.Collapsed && btn03.Visibility==Visibility.Collapsed && btn04.Visibility==Visibility.Collapsed && btn05.Visibility==Visibility.Collapsed && (s==0 || sc==0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            btn05.IsEnabled = true;
            btn4.IsEnabled = false;
            btn6.IsEnabled = false;
            btn1.IsEnabled = false;
            btn10.IsEnabled = false;
            button11.IsEnabled = false;
            imng1.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Visible;
            imng3.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Collapsed;
            imng5.Visibility = Visibility.Collapsed;
            DR:
            randomNumber2[i] = random1.Next(0, 5);
            
            if (i == 1 && randomNumber2[1] == randomNumber2[0])
            {
                goto DR;
            }
            if (i == 2 && (randomNumber2[2] == randomNumber2[0] || randomNumber2[2] == randomNumber2[1]))
            {
                goto DR;
            }
            if (i == 3 && (randomNumber2[3] == randomNumber2[0] || randomNumber2[3] == randomNumber2[1] || randomNumber2[3] == randomNumber2[2]))
            {
                goto DR;
            }
            if (i == 4 && (randomNumber2[4] == randomNumber2[0] || randomNumber2[4] == randomNumber2[1] || randomNumber2[4] == randomNumber2[2] || randomNumber2[4] == randomNumber2[3]))
            {
                goto DR;
            }
            if (i == 5 && (randomNumber2[5] == randomNumber2[0] || randomNumber2[5] == randomNumber2[1] || randomNumber2[5] == randomNumber2[2] || randomNumber2[5] == randomNumber2[3] || randomNumber2[5] == randomNumber2[4]))
            {
                goto DR;
            }
          
            switch (randomNumber2[i])
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
            
            if (i!=0 && randomNumber1[i-1] == randomNumber2[i])
            {
                s += 1;
                sc -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            
            }
            else
            {
                cc += 1;
                p[cc] = randomNumber2[i];
            }
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            btn05.IsEnabled = true;
            btn4.IsEnabled = false;
            btn6.IsEnabled = false;
            btn1.IsEnabled = false;
            btn10.IsEnabled = false;
            button11.IsEnabled = false;
            imng1.Visibility = Visibility.Collapsed;
            imng3.Visibility = Visibility.Visible;
            imng2.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Collapsed;
            imng5.Visibility = Visibility.Collapsed;
        MR:
            randomNumber2[i] = random1.Next(0, 5);

            if (i == 1 && randomNumber2[1] == randomNumber2[0])
            {
                goto MR;
            }
            if (i == 2 && (randomNumber2[2] == randomNumber2[0] || randomNumber2[2] == randomNumber2[1]))
            {
                goto MR;
            }
            if (i == 3 && (randomNumber2[3] == randomNumber2[0] || randomNumber2[3] == randomNumber2[1] || randomNumber2[3] == randomNumber2[2]))
            {
                goto MR;
            }
            if (i == 4 && (randomNumber2[4] == randomNumber2[0] || randomNumber2[4] == randomNumber2[1] || randomNumber2[4] == randomNumber2[2] || randomNumber2[4] == randomNumber2[3]))
            {
                goto MR;
            }
            if (i == 5 && (randomNumber2[5] == randomNumber2[0] || randomNumber2[5] == randomNumber2[1] || randomNumber2[5] == randomNumber2[2] || randomNumber2[5] == randomNumber2[3] || randomNumber2[5] == randomNumber2[4]))
            {
                goto MR;
            }
            switch (randomNumber2[i])
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
            
            if (i!=0 && randomNumber1[i-1] == randomNumber2[i])
            {
                s += 1;
                sc -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                cc += 1;
                p[cc] = randomNumber2[i];
            }
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
        }

        private void btn10_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            btn05.IsEnabled = true;
            btn4.IsEnabled = false;
            btn6.IsEnabled = false;
            btn1.IsEnabled = false;
            btn10.IsEnabled = false;
            button11.IsEnabled = false;
            imng1.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Visible;
            imng2.Visibility = Visibility.Collapsed;
            imng3.Visibility = Visibility.Collapsed;
            imng5.Visibility = Visibility.Collapsed;
        PR:
            randomNumber2[i] = random1.Next(0, 5);

            if (i == 1 && randomNumber2[1] == randomNumber2[0])
            {
                goto PR;
            }
            if (i == 2 && (randomNumber2[2] == randomNumber2[0] || randomNumber2[2] == randomNumber2[1]))
            {
                goto PR;
            }
            if (i == 3 && (randomNumber2[3] == randomNumber2[0] || randomNumber2[3] == randomNumber2[1] || randomNumber2[3] == randomNumber2[2]))
            {
                goto PR;
            }
            if (i == 4 && (randomNumber2[4] == randomNumber2[0] || randomNumber2[4] == randomNumber2[1] || randomNumber2[4] == randomNumber2[2] || randomNumber2[4] == randomNumber2[3]))
            {
                goto PR;
            }
            if (i == 5 && (randomNumber2[5] == randomNumber2[0] || randomNumber2[5] == randomNumber2[1] || randomNumber2[5] == randomNumber2[2] || randomNumber2[5] == randomNumber2[3] || randomNumber2[5] == randomNumber2[4]))
            {
                goto PR;
            }
            switch (randomNumber2[i])
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
            
            if (i!=0 && randomNumber1[i-1] == randomNumber2[i])
            {
                s += 1;
                sc -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                cc += 1;
                p[cc] = randomNumber2[i];
            }
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
        }


        private void button11_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = true;
            btn02.IsEnabled = true;
            btn03.IsEnabled = true;
            btn04.IsEnabled = true;
            btn05.IsEnabled = true;
            btn4.IsEnabled = false;
            btn6.IsEnabled = false;
            btn1.IsEnabled = false;
            btn10.IsEnabled = false;
            button11.IsEnabled = false;
            imng1.Visibility = Visibility.Collapsed;
            imng5.Visibility = Visibility.Visible;
            imng3.Visibility = Visibility.Collapsed;
            imng4.Visibility = Visibility.Collapsed;
            imng2.Visibility = Visibility.Collapsed;
        DO:
            randomNumber2[i] = random1.Next(0, 5);

            if (i == 1 && randomNumber2[1] == randomNumber2[0])
            {
                goto DO;
            }
            if (i == 2 && (randomNumber2[2] == randomNumber2[0] || randomNumber2[2] == randomNumber2[1]))
            {
                goto DO;
            }
            if (i == 3 && (randomNumber2[3] == randomNumber2[0] || randomNumber2[3] == randomNumber2[1] || randomNumber2[3] == randomNumber2[2]))
            {
                goto DO;
            }
            if (i == 4 && (randomNumber2[4] == randomNumber2[0] || randomNumber2[4] == randomNumber2[1] || randomNumber2[4] == randomNumber2[2] || randomNumber2[4] == randomNumber2[3]))
            {
                goto DO;
            }
            if (i == 5 && (randomNumber2[5] == randomNumber2[0] || randomNumber2[5] == randomNumber2[1] || randomNumber2[5] == randomNumber2[2] || randomNumber2[5] == randomNumber2[3] || randomNumber2[5] == randomNumber2[4]))
            {
                goto DO;
            }
            switch (randomNumber2[i])
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
            button11.Visibility = Visibility.Collapsed;
            
            if (i!=0 && randomNumber1[i-1] == randomNumber2[i])
            {
                s += 1;
                sc -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                cc += 1;
                p[cc] = randomNumber2[i];
            }
            score.Text = Convert.ToString(s);
            score2.Text = Convert.ToString(sc);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
        }

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = false;
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
            btn04.IsEnabled = false;
            btn05.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            button11.IsEnabled = true;
            imng7.Visibility = Visibility.Collapsed;
            imng6.Visibility = Visibility.Visible;
            imng8.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Collapsed;
            imng10.Visibility = Visibility.Collapsed;
            o:
            randomNumber1[i]= random1.Next(0, 5);
            if (i == 1 && randomNumber1[1] == randomNumber1[0])
            {
                goto o;
            }
            if (i == 2 && (randomNumber1[2] == randomNumber1[0] || randomNumber1[2] == randomNumber1[1]))
            {
                goto o;
            }
            if (i == 3 && (randomNumber1[3] == randomNumber1[0] || randomNumber1[3] == randomNumber1[1] || randomNumber1[3] == randomNumber1[2]))
            {
                goto o;
            }
            if (i == 4 && (randomNumber1[4] == randomNumber1[0] || randomNumber1[4] == randomNumber1[1] || randomNumber1[4] == randomNumber1[2] || randomNumber1[4] == randomNumber1[3]))
            {
                goto o;
            }
           
            switch (randomNumber1[i])
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
            
            if (randomNumber1[i]==randomNumber2[i])
            {
                sc += 1;
                s -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                dd += 1;
                q[dd] = randomNumber1[i];
            }

            score2.Text = Convert.ToString(sc);
            score.Text = Convert.ToString(s);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
                quit.Visibility = Visibility.Collapsed;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }

            i += 1;
        }

        private void btn02_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = false;
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
            btn04.IsEnabled = false;
            btn05.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            button11.IsEnabled = true;
            imng6.Visibility = Visibility.Collapsed;
            imng7.Visibility = Visibility.Visible;
            imng8.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Collapsed;
            imng10.Visibility = Visibility.Collapsed;
        os:
            randomNumber1[i] = random1.Next(0, 5);
            if (i == 1 && randomNumber1[1] == randomNumber1[0])
            {
                goto os;
            }
            if (i == 2 && (randomNumber1[2] == randomNumber1[0] || randomNumber1[2] == randomNumber1[1]))
            {
                goto os;
            }
            if (i == 3 && (randomNumber1[3] == randomNumber1[0] || randomNumber1[3] == randomNumber1[1] || randomNumber1[3] == randomNumber1[2]))
            {
                goto os;
            }
            if (i == 4 && (randomNumber1[4] == randomNumber1[0] || randomNumber1[4] == randomNumber1[1] || randomNumber1[4] == randomNumber1[2] || randomNumber1[4] == randomNumber1[3]))
            {
                goto os;
            }
            switch (randomNumber1[i])
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
            
            if (randomNumber1[i] == randomNumber2[i])
            {
                sc += 1;
                s -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                dd += 1;
                q[dd] = randomNumber1[i];
            }
            score2.Text = Convert.ToString(sc);
            score.Text = Convert.ToString(s);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
                quit.Visibility = Visibility.Collapsed;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            i += 1;
        }

        private void btn03_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = false;
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
            btn04.IsEnabled = false;
            btn05.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            button11.IsEnabled = true;
            imng7.Visibility = Visibility.Collapsed;
            imng8.Visibility = Visibility.Visible;
            imng6.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Collapsed;
            imng10.Visibility = Visibility.Collapsed;
        oo:
            randomNumber1[i] = random1.Next(0, 5);
            if (i == 1 && randomNumber1[1] == randomNumber1[0])
            {
                goto oo;
            }
            if (i == 2 && (randomNumber1[2] == randomNumber1[0] || randomNumber1[2] == randomNumber1[1]))
            {
                goto oo;
            }
            if (i == 3 && (randomNumber1[3] == randomNumber1[0] || randomNumber1[3] == randomNumber1[1] || randomNumber1[3] == randomNumber1[2]))
            {
                goto oo;
            }
            if (i == 4 && (randomNumber1[4] == randomNumber1[0] || randomNumber1[4] == randomNumber1[1] || randomNumber1[4] == randomNumber1[2] || randomNumber1[4] == randomNumber1[3]))
            {
                goto oo;
            }
            switch (randomNumber1[i])
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
            btn03.Visibility = Visibility.Collapsed;
            
            if (randomNumber1[i] == randomNumber2[i])
            {
                sc += 1;
                s -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                dd += 1;
                q[dd] = randomNumber1[i];
            }
            score2.Text = Convert.ToString(sc);
            score.Text = Convert.ToString(s);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
                quit.Visibility = Visibility.Collapsed;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            i += 1;
        }

        private void btn04_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = false;
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
            btn04.IsEnabled = false;
            btn05.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            button11.IsEnabled = true;
            imng7.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Visible;
            imng8.Visibility = Visibility.Collapsed;
            imng6.Visibility = Visibility.Collapsed;
            imng10.Visibility = Visibility.Collapsed;
        oi:
            randomNumber1[i] = random1.Next(0, 5);
            if (i == 1 && randomNumber1[1] == randomNumber1[0])
            {
                goto oi;
            }
            if (i == 2 && (randomNumber1[2] == randomNumber1[0] || randomNumber1[2] == randomNumber1[1]))
            {
                goto oi;
            }
            if (i == 3 && (randomNumber1[3] == randomNumber1[0] || randomNumber1[3] == randomNumber1[1] || randomNumber1[3] == randomNumber1[2]))
            {
                goto oi;
            }
            if (i == 4 && (randomNumber1[4] == randomNumber1[0] || randomNumber1[4] == randomNumber1[1] || randomNumber1[4] == randomNumber1[2] || randomNumber1[4] == randomNumber1[3]))
            {
                goto oi;
            }
            switch (randomNumber1[i])
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
            btn04.Visibility = Visibility.Collapsed;
            
            if (randomNumber1[i] == randomNumber2[i])
            {
                sc += 1;
                s -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                dd += 1;
                q[dd] = randomNumber1[i];
            }
            score2.Text = Convert.ToString(sc);
            score.Text = Convert.ToString(s);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
                quit.Visibility = Visibility.Collapsed;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            i += 1;
        }

        private void btn05_Click(object sender, RoutedEventArgs e)
        {
            md.Stop();
            mdia.Source = new Uri(@"ms-appx:///Assets/turn.wav");
            mdia.Play();
            btn01.IsEnabled = false;
            btn02.IsEnabled = false;
            btn03.IsEnabled = false;
            btn04.IsEnabled = false;
            btn05.IsEnabled = false;
            btn4.IsEnabled = true;
            btn6.IsEnabled = true;
            btn1.IsEnabled = true;
            btn10.IsEnabled = true;
            button11.IsEnabled = true;
            imng7.Visibility = Visibility.Collapsed;
            imng10.Visibility = Visibility.Visible;
            imng8.Visibility = Visibility.Collapsed;
            imng9.Visibility = Visibility.Collapsed;
            imng6.Visibility = Visibility.Collapsed;
        oas:
            randomNumber1[i] = random1.Next(0, 5);
            if (i == 1 && randomNumber1[1] == randomNumber1[0])
            {
                goto oas;
            }
            if (i == 2 && (randomNumber1[2] == randomNumber1[0] || randomNumber1[2] == randomNumber1[1]))
            {
                goto oas;
            }
            if (i == 3 && (randomNumber1[3] == randomNumber1[0] || randomNumber1[3] == randomNumber1[1] || randomNumber1[3] == randomNumber1[2]))
            {
                goto oas;
            }
            if (i == 4 && (randomNumber1[4] == randomNumber1[0] || randomNumber1[4] == randomNumber1[1] || randomNumber1[4] == randomNumber1[2] || randomNumber1[4] == randomNumber1[3]))
            {
                goto oas;
            }
            switch (randomNumber1[i])
            {
                case 0:
                    image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/batista.jpg"));
                    break;
                case 1:
                    image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/kane.jpg"));
                    break;
                case 2:
                    image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cena.jpg"));
                    break;
                case 3:
                    image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/cm.jpg"));
                    break;
                case 4:
                    image10.Source = new BitmapImage(new Uri(@"ms-appx:///Assets/under.jpg"));
                    break;
                
            }
            btn05.Visibility = Visibility.Collapsed;
            
            if (randomNumber1[i] == randomNumber2[i])
            {
                sc += 1;
                s -= 1;
                md.Source = new Uri(@"ms-appx:///Assets/match.wav");
                md.Play();
            }
            else
            {
                dd += 1;
                q[dd] = randomNumber1[i];
            }
            score2.Text = Convert.ToString(sc);
            score.Text = Convert.ToString(s);
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s == 0 || sc == 0))
            {
                winner.Visibility = Visibility.Visible;
                quit.Visibility = Visibility.Collapsed;
            }
            if (btn1.Visibility == Visibility.Collapsed && btn4.Visibility == Visibility.Collapsed && btn6.Visibility == Visibility.Collapsed && btn10.Visibility == Visibility.Collapsed && button11.Visibility == Visibility.Collapsed && btn01.Visibility == Visibility.Collapsed && btn02.Visibility == Visibility.Collapsed && btn03.Visibility == Visibility.Collapsed && btn04.Visibility == Visibility.Collapsed && btn05.Visibility == Visibility.Collapsed && (s != 0 || sc != 0))
            {
                quit.Visibility = Visibility.Collapsed;
                dat.Interval = TimeSpan.FromSeconds(2);
                dat.Tick += dat_Tick;
                dat.Start();
            }
            i += 1;
 
        }
        void dat_Tick(object sender, object e)
        {
            dat.Stop();
            if (s == 1)
            {
                this.Frame.Navigate(typeof(BlankPage13));
            }
            if(s==2)
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
            if (sc==1)
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