using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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
    /// Intro.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Intro : Page
    {
        DispatcherTimer timer;

        int counter = 0;
        int length = 0;
        string text;

        public Intro()
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Start();
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            text = txt_Intro.Text;
            length = txt_Intro.Text.Length;
            txt_Intro.Text = string.Empty;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txt_Intro.Text = text.Substring(0, counter);
            counter++;

            if (counter > length)
            {
                timer.Stop();
            }
        }

    }
}
