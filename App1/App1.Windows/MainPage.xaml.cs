using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238


    //Gitrhub sdsdasdasdasdasd

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            ShowMessageDialog();
        }

        public async void ShowMessageDialog()
        {
            await new MessageDialog("טקסט: מכללת סלע, 937", "כותרת: סלע מעבדות תוכנה").ShowAsync();
        }

        private void changemainbrd1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            maingrid.Background = changemainbrd1.Background;
        }

        private void changemainbrd2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            maingrid.Background = changemainbrd2.Background;
        }
    }
}
