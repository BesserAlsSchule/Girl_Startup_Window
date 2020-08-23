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

namespace Anne_startup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //object sender;
        //RoutedEventArgs e;

        //Verbindungsstrings für Websites
        string Asos = "https://www.asos.com/de/damen/";
        string About_you = "https://www.aboutyou.de/dein-shop";
        string Pinterest = "https://www.pinterest.de/";
        string Zooplus = "https://www.zooplus.de/";
        string Googelinger = "https://www.google.de";

        //Starte Fenster
        public MainWindow()
        {
            dispatcherTimerLabel(); //Uhr initialisierung
            InitializeComponent();
        }
        //Label.Content bindings?: http://www.sws.bfh.ch/~amrhein/Skripten/Info2/05.DataBinding.pdf
        //DISPATCHER TIMER https://stackoverflow.com/questions/17233651/wpf-data-binding-label-content

            public void dispatcherTimerLabel()
            {
                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromMilliseconds(100);
                timer.Tick += timer_Tick;
                timer.Start();
            }

            public void timer_Tick(object sender, EventArgs e)
            {
                DispatcherTimerLabel.Content = DateTime.Now.ToLongTimeString();
            }
        
        //acessor für dTimerLabel Content --> unnötig
        private string DTimerOutput;

        public string dTimerOut
        {
            get { return DTimerOutput; }
            set { DTimerOutput = value; }
        }
        //LOOP FÜR GIF
        private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            Pusheen_Sombrero.Position = new TimeSpan(0, 0, 10);
            Pusheen_Sombrero.Play();
        }

        public void mySpaceGif(object sender, RoutedEventArgs e) 
        {
            spaceCat.Position = new TimeSpan(0, 0, 10);
            spaceCat.Play();
        }
        //BUTTONS
        private void button_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Asos,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = About_you,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Pinterest,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Zooplus,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Googelinger,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
