using HHW.Tools.Shared;
using System;
using System.Collections.Generic;
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

namespace HHW.Tools.TrackMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public BitmapImage BasinImage;

        public TrackMaker TrackMaker { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Init();



        }

        internal void Init()
        {
            // Init code for the trackmaker.  

            TrackMaker = new TrackMaker();

            BasinImage = new BitmapImage();
            BasinImage.BeginInit(); // initialize
            BasinImage.UriSource = new Uri(AppDomain.CurrentDomain.BaseDirectory + "Resources/Images/T_AtlanticHighRes.png");
            BasinImage.EndInit();
            Basin.Source = BasinImage; // yeah
            return;

        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }


    }

    
}
