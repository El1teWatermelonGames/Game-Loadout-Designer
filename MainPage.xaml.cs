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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Game_Loadout_Designer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void ClearPanel()
        {
            BF2042Grid.Visibility = Visibility.Collapsed;
            CODMWII22Grid.Visibility = Visibility.Collapsed;
        }

        private void BF2042_Click(object sender, RoutedEventArgs e)
        {
            ClearPanel();
            BF2042Grid.Visibility = Visibility.Visible;
        }

        private void CODMWII22_Click(object sender, RoutedEventArgs e)
        {
            ClearPanel();
            CODMWII22Grid.Visibility = Visibility.Visible;
        }
    }
}
