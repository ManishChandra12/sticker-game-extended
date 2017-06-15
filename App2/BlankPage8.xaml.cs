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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage8 : Page
    {
        public  static string s1;
        public  static string s2;
        public BlankPage8()
        {
            this.InitializeComponent();
            
           
            
           
           
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog error = new MessageDialog("Player(s) name missing! Try Again!");
            if (nm.Text == "" || nme.Text == "")
            {
                await error.ShowAsync();
            }
            else
            {
                
                s1 = nm.Text;
                s2 = nme.Text;
                this.Frame.Navigate(typeof(BlankPage1));
            }
            

        }

        

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage6));
        }

        private void cntd_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            jpt1.Source = new Uri(@"ms-appx:///Assets/button.wav");
            jpt1.Play();
        }
    }
}
