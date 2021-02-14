using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Introduce
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            left_Frame.Content = new Intro();
            
        }

        private void grid_menu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            left_Frame.Content = new Home();
        }

        private void btn_Contact_Click(object sender, RoutedEventArgs e)
        {
            left_Frame.Content = new Contact();
        }

        private void btn_WindowMini_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_WindowClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Github_Click(object sender, RoutedEventArgs e)
        {
            var url = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = "https://github.com/NextPaige"
            };
            Process.Start(url);
        }
    }
}
